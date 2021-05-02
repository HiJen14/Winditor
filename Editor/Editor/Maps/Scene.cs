﻿using GameFormatReader.Common;
using System.Collections.Generic;
using System.IO;
using WindEditor.Collision;
using JStudio.J3D;
using System;
using WArchiveTools.FileSystem;

namespace WindEditor
{
    public abstract class WScene : WDOMNode
    {
        override public string Name { get; set; }
        public VirtualFilesystemDirectory SourceDirectory { get; set; }

        protected Dictionary<FourCC, WDOMNode> m_fourCCGroups;

        protected static Dictionary<FourCC, SourceScene> m_fourCCLocations;

        public int RoomIndex { get; protected set; }

        static WScene()
        {
            m_fourCCLocations = new Dictionary<FourCC, SourceScene>();

            m_fourCCLocations.Add(FourCC.EnvR, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.Colo, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.Pale, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.Virt, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.EVNT, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.RTBL, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.STAG, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.MEMA, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.MECO, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.DMAP, SourceScene.Stage);
            m_fourCCLocations.Add(FourCC.MULT, SourceScene.Stage);

            m_fourCCLocations.Add(FourCC.FILI, SourceScene.Room);
        }

        public WScene(WWorld world) : base(world)
        {
            RoomIndex = -1;

            m_fourCCGroups = new Dictionary<FourCC, WDOMNode>();

            // We're going to iterate through the enum values to create DOM nodes for them.
            // We're skipping all of the actors, scaleable objects, and treasure chests though, because they're special.
            foreach (FourCC f in Enum.GetValues(typeof(FourCC)))
            {
                // Skip Actors/Scaleable Objects/Treasure Chests
                if (f.ToString().Contains("ACT") || f.ToString().Contains("SCO") || f.ToString().Contains("TRE") || f == FourCC.NONE)
                {
                    continue;
                }

                if (!m_fourCCLocations.ContainsKey(f) || this is WStage && m_fourCCLocations[f] == SourceScene.Stage || this is WRoom && m_fourCCLocations[f] == SourceScene.Room)
                    m_fourCCGroups[f] = new WDOMGroupNode(f, m_world);
            }

            // To handle the fact that actors/scaleable/treasure chests have layers, we're going to create DOM nodes using
            // the default layer's FourCC (ACTR/SCOB/TRES). This DOM node won't interact directly with the entities, rather
            // it will be the parent node of the nodes that do. WDOMGroupNode.ToString() is overridden to return a more general
            // description of them ("ACTR (Actors)", etc) instead of the FourCC's FourCCConversion.GetDescriptionFromEnum() value.
            m_fourCCGroups[FourCC.ACTR] = new WDOMGroupNode(FourCC.ACTR, m_world);
            m_fourCCGroups[FourCC.SCOB] = new WDOMGroupNode(FourCC.SCOB, m_world);
            m_fourCCGroups[FourCC.TRES] = new WDOMGroupNode(FourCC.TRES, m_world);

            // Now we add the default layer for each object type. WDOMLayeredGroupNode directly interacts with the entities.
            WDOMLayeredGroupNode actrDefLayer = new WDOMLayeredGroupNode(FourCC.ACTR, MapLayer.Default, m_world);
            actrDefLayer.SetParent(m_fourCCGroups[FourCC.ACTR]);

            WDOMLayeredGroupNode scobDefLayer = new WDOMLayeredGroupNode(FourCC.SCOB, MapLayer.Default, m_world);
            scobDefLayer.SetParent(m_fourCCGroups[FourCC.SCOB]);

            WDOMLayeredGroupNode tresDefLayer = new WDOMLayeredGroupNode(FourCC.TRES, MapLayer.Default, m_world);
            tresDefLayer.SetParent(m_fourCCGroups[FourCC.TRES]);

            // Now we add layers 0 to 11 for each object type.
            // Note that we do (i + 1) for the MapLayer cast in order to skip the Default enum value.
            for (int i = 0; i < 12; i++)
            {
                WDOMLayeredGroupNode actrLayer = new WDOMLayeredGroupNode(FourCCConversion.GetEnumFromString($"ACT{ i.ToString("x") }"), (MapLayer)i + 1, m_world);
                actrLayer.SetParent(m_fourCCGroups[FourCC.ACTR]);

                WDOMLayeredGroupNode scobLayer = new WDOMLayeredGroupNode(FourCCConversion.GetEnumFromString($"SCO{ i.ToString("x") }"), (MapLayer)i + 1, m_world);
                scobLayer.SetParent(m_fourCCGroups[FourCC.SCOB]);

                WDOMLayeredGroupNode tresLayer = new WDOMLayeredGroupNode(FourCCConversion.GetEnumFromString($"TRE{ i.ToString("x") }"), (MapLayer)i + 1, m_world);
                tresLayer.SetParent(m_fourCCGroups[FourCC.TRES]);
            }

            /*m_fourCCGroups["ACTR (Actors)"] = new WDOMGroupNode("ACTR (Actors)", m_world);
            WDOMGroupNode actrDefault = new WDOMGroupNode("ACTR", m_world);
            actrDefault.SetParent(m_fourCCGroups["ACTR (Actors)"]);

            m_fourCCGroups["SCOB (Scaleable Objects)"] = new WDOMGroupNode("SCOB (Scaleable Objects)", m_world);
            WDOMGroupNode scobDefault = new WDOMGroupNode("SCOB", m_world);
            scobDefault.SetParent(m_fourCCGroups["SCOB (Scaleable Objects)"]);

            m_fourCCGroups["TRES (Treasure Chests)"] = new WDOMGroupNode("TRES (Treasure Chests)", m_world);
            WDOMGroupNode tresDefault = new WDOMGroupNode("TRES", m_world);
            tresDefault.SetParent(m_fourCCGroups["TRES (Treasure Chests)"]);

            for (int i = 0; i < 12; i++)
            {
                WDOMGroupNode actX = new WDOMGroupNode($"ACT{ i.ToString("x") }", m_world);
                actX.SetParent(m_fourCCGroups["ACTR (Actors)"]);

                WDOMGroupNode scoX = new WDOMGroupNode($"SCO{ i.ToString("x") }", m_world);
                scoX.SetParent(m_fourCCGroups["SCOB (Scaleable Objects)"]);

                WDOMGroupNode treX = new WDOMGroupNode($"TRE{ i.ToString("x") }", m_world);
                treX.SetParent(m_fourCCGroups["TRES (Treasure Chests)"]);
            }*/
        }

        public virtual void Load(string filePath)
        {
            Name = Path.GetFileNameWithoutExtension(filePath);
        }

        protected virtual J3D LoadModel(string rootFolder, string modelName)
        {
            string[] extNames = new[] { ".bmd", ".bdl" };
            foreach (var ext in extNames)
            {
                string fullPath = Path.Combine(rootFolder, modelName + ext);
                if (File.Exists(fullPath))
                {
                    J3D j3dMesh = WResourceManager.LoadResource(fullPath);

                    // Now that we've loaded a j3dMesh, we're going to try loading btk anims too.
                    string btkFolder = rootFolder + "\\..\\btk\\";
                    string btkFile = btkFolder + modelName + ".btk";

                    if (File.Exists(btkFile))
                    {
                        j3dMesh.LoadMaterialAnim(btkFile);
                        j3dMesh.SetMaterialAnimation(modelName);
                    }

                    return j3dMesh;
                }
            }

            return null;
        }


        public virtual void UnloadLevel()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void LoadLevelCollisionFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            CategoryDOMNode col_category = new CategoryDOMNode("Collision", m_world);
            col_category.SetParent(this);

            WCollisionMesh collision = new WCollisionMesh(m_world, filePath);
            collision.SetParent(col_category);
        }

        protected virtual void LoadLevelEntitiesFromFile(string filePath)
        {
            SceneDataLoader actorLoader = new SceneDataLoader(filePath, m_world);

            Console.WriteLine(Path.GetFileName(filePath));
            List<WDOMNode> loadedActors = actorLoader.GetMapEntities();

			foreach(var child in loadedActors)
			{
				var fourCCEntity = (SerializableDOMNode)child;

				if(fourCCEntity.FourCC >= FourCC.ACTR && fourCCEntity.FourCC <= FourCC.ACTb)
                    child.SetParent(m_fourCCGroups[FourCC.ACTR].Children[(int)fourCCEntity.Layer]);

				else if (fourCCEntity.FourCC >= FourCC.SCOB && fourCCEntity.FourCC <= FourCC.SCOb)
					child.SetParent(m_fourCCGroups[FourCC.SCOB].Children[(int)fourCCEntity.Layer]);

				else if (fourCCEntity.FourCC >= FourCC.TRES && fourCCEntity.FourCC <= FourCC.TREb)
					child.SetParent(m_fourCCGroups[FourCC.TRES].Children[(int)fourCCEntity.Layer]);

				else
					child.SetParent(m_fourCCGroups[fourCCEntity.FourCC]);

                //m_fourCCGroups[fourCCEntity.FourCC].Children.Add(fourCCEntity);
                //child.SetParent(m_fourCCGroups[fourCCEntity.FourCC]);
				child.IsVisible = true;
			}

            List<KeyValuePair<string, FourCC>> dispFourCCs = new List<KeyValuePair<string, FourCC>>();
            foreach (var item in m_fourCCGroups)
            {
                dispFourCCs.Add(new KeyValuePair<string, FourCC>(item.Value.ToString(), item.Key));
            }

            // Sort the FourCCs alphabetically by their ToString() value
            for (int i = 0; i < dispFourCCs.Count; i++)
            {
                for (int j = i; j < dispFourCCs.Count; j++)
                {
                    if (dispFourCCs[i].Key.CompareTo(dispFourCCs[j].Key) > 0)
                    {
                        KeyValuePair<string, FourCC> temp = dispFourCCs[i];
                        dispFourCCs[i] = dispFourCCs[j];
                        dispFourCCs[j] = temp;
                    }
                }
            }

            // Add entities to the DOM in the sorted order
            foreach (KeyValuePair<string, FourCC> keyVal in dispFourCCs)
            {
                m_fourCCGroups[keyVal.Value].SetParent(this);
            }

            foreach (var child in loadedActors)
            {
                if (child is SerializableDOMNode)
                {
                    SerializableDOMNode child_as_vis = child as SerializableDOMNode;
                    child_as_vis.PostLoad();
                }
            }
        }

        public virtual void SaveToDirectory(string directory)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            Console.WriteLine("Saving {0} to {1}...", Name, directory);

            Console.WriteLine("Writing DZR/DZS File...");
            SaveEntitiesToDirectory(directory);
            Console.WriteLine("Finished saving DZR/DZS File.");

            Console.WriteLine("Writing DZB File...");
            SaveCollisionToDirectory(directory);
            Console.WriteLine("Finished saving DZB File.");

            Console.WriteLine("Writing BMD/BDL Files...");
            SaveModelsToDirectory(directory);
            Console.WriteLine("Finished saving BMD/BDL files.");

            Console.WriteLine("Finished Saving {0}.", Name);

        }

        public abstract void SaveEntitiesToDirectory(string directory);
        public abstract void SaveCollisionToDirectory(string directory);
        public virtual void SaveModelsToDirectory(string directory)
        {
            List<J3DNode> models = GetChildrenOfType<J3DNode>();
            if (models.Count <= 0)
            {
                return;
            }

            string folderName = "";

            if (models[0].Model.StudioType.Contains("bdl"))
            {
                folderName = "bdl";
            }
            else
            {
                folderName = "bmd";
            }

            string finalDirName = Path.Combine(directory, folderName);

            if (!Directory.Exists(finalDirName))
                Directory.CreateDirectory(finalDirName);

            foreach (J3DNode node in models)
            {
                if (!File.Exists(node.Filename))
                {
                    Console.WriteLine($"File { node.Filename } does not exist anymore!");
                    continue;
                }

                string destPath = Path.Combine(finalDirName, node.Name + $".{ folderName }");

                File.Copy(node.Filename, destPath, true);
            }
        }

        public virtual VirtualFilesystemDirectory ExportToVFS()
        {
            return null;
        }
    }
}

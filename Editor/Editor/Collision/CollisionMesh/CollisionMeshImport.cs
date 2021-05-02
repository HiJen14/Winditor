﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFormatReader.Common;
using OpenTK;
using Collada141;

namespace WindEditor.Collision
{
    public partial class WCollisionMesh
    {
        #region Loading from DZB
        public void LoadFromDZB(EndianBinaryReader stream)
        {
            List<Vector3> temp_vertices = new List<Vector3>();

            int vertexCount = stream.ReadInt32();
            int vertexOffset = stream.ReadInt32();
            int triangleCount = stream.ReadInt32();
            int triangleOffset = stream.ReadInt32();
            stream.SkipInt32(); // Number of octree indices
            stream.SkipInt32(); // Octree indices
            stream.SkipInt32(); // Number of octree nodes
            stream.SkipInt32(); // Octree nodes
            int groupCount = stream.ReadInt32();
            int groupOffset = stream.ReadInt32();
            int propertyCount = stream.ReadInt32();
            int propertyOffset = stream.ReadInt32();

            LoadVerticesFromDZB(stream, temp_vertices, vertexOffset, vertexCount);
            LoadGroupsFromDZB(stream, groupOffset, groupCount);
            LoadPropertiesFromDZB(stream, propertyOffset, propertyCount);
            LoadTrianglesFromDZB(stream, temp_vertices, triangleOffset, triangleCount);

            FinalizeLoad();
        }

        private void LoadVerticesFromDZB(EndianBinaryReader reader, List<Vector3> buffer, int offset, int count)
        {
            reader.BaseStream.Position = offset;

            for (int i = 0; i < count; i++)
            {
                buffer.Add(new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle()));
            }
        }

        private void LoadGroupsFromDZB(EndianBinaryReader reader, int offset, int count)
        {
            reader.BaseStream.Position = offset;

            for (int i = 0; i < count; i++)
            {
                m_Nodes.Add(new CollisionGroupNode(reader));
            }

            RootNode = m_Nodes[0];
            RootNode.InflateHierarchyRecursive(null, m_Nodes);
        }

        private void LoadPropertiesFromDZB(EndianBinaryReader reader, int offset, int count)
        {
            m_Properties = new CollisionProperty[count];
            reader.BaseStream.Position = offset;

            for (int i = 0; i < count; i++)
            {
                CollisionProperty new_prop = new CollisionProperty(reader);
                m_Properties[i] = new_prop;
            }
        }

        private void LoadTrianglesFromDZB(EndianBinaryReader reader, List<Vector3> vertices, int offset, int count)
        {
            reader.BaseStream.Position = offset;

            for (int i = 0; i < count; i++)
            {
                CollisionTriangle new_tri = new CollisionTriangle(reader, vertices, m_Nodes, m_Properties);
                Triangles.Add(new_tri);
            }
        }
        #endregion

        #region Loading from COLLADA
        public void FromDAEFile(string file_name, int roomIndex)
        {
            int origRootRoomTableIndex = RootNode.RoomTableIndex;

            COLLADA dae = COLLADA.Load(file_name);
            m_Nodes = new List<CollisionGroupNode>();
            Triangles = new List<CollisionTriangle>();
            LoadFromCollada(dae, roomIndex, origRootRoomTableIndex);
        }

        private void LoadFromCollada(COLLADA dae, int roomIndex, int roomTableIndex)
        {
            m_UpAxis = dae.asset.up_axis;

            library_geometries geo = (library_geometries)Array.Find(dae.Items, x => x.GetType() == typeof(library_geometries));
            library_visual_scenes vis = (library_visual_scenes)Array.Find(dae.Items, x => x.GetType() == typeof(library_visual_scenes));

            visual_scene scene = vis.visual_scene[0];

            RootNode = LoadGroupsFromColladaRecursive(null, scene.node[0], geo.geometry);

            FinalizeLoad();

            // Automatically set the room number.
            RootNode.RoomNumber = roomIndex;

            // Copy the room table index used by the original collision mesh's root node to all of the groups loaded from the dae.
            // This isn't perfect because some rooms (like dungeon hub rooms) have different collision groups using different room tables, and this method doesn't preserve that.
            // But this does work much better than not setting the room table index at all.
            foreach (CollisionGroupNode node in m_Nodes)
            {
                node.RoomTableIndex = roomTableIndex;
            }
        }

        private void LoadFromObj(string[] lines, int roomIndex, int roomTableIndex)
        {
            RootNode = new CollisionGroupNode(null, string.Format("R{0}", roomTableIndex.ToString("D2")));
            m_Nodes.Add(RootNode);

            CollisionGroupNode CurrentCategory = null;
            CollisionGroupNode CurrentGroup = null;

            List<Vector3> Vertices = new List<Vector3>();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] SplitLine = lines[i].Split(' ');

                switch(SplitLine[0])
                {
                    case "o":
                        CurrentCategory = new CollisionGroupNode(RootNode, $"C_{ SplitLine[1] }");
                        CurrentGroup = new CollisionGroupNode(CurrentCategory, $"G_{ SplitLine[1] }");

                        RootNode.Children.Add(CurrentCategory);
                        CurrentCategory.Children.Add(CurrentGroup);

                        m_Nodes.Add(CurrentCategory);
                        m_Nodes.Add(CurrentGroup);
                        break;
                    case "v":
                        // We've been burned by Europe before since they use , instead of . for marking decimal places. So this just makes sure that's not an issue.
                        float XCoord = Convert.ToSingle(SplitLine[1].Replace(',', '.'));
                        float YCoord = Convert.ToSingle(SplitLine[2].Replace(',', '.'));
                        float ZCoord = Convert.ToSingle(SplitLine[3].Replace(',', '.'));

                        Vertices.Add(new Vector3(XCoord, YCoord, ZCoord));
                        break;
                    case "f":
                        int V1 = Convert.ToInt32(SplitLine[1].Split('/')[0]) - 1;
                        int V2 = Convert.ToInt32(SplitLine[2].Split('/')[0]) - 1;
                        int V3 = Convert.ToInt32(SplitLine[3].Split('/')[0]) - 1;

                        CollisionTriangle NewTri = new CollisionTriangle(Vertices[V1], Vertices[V2], Vertices[V3], CurrentGroup);

                        Triangles.Add(NewTri);
                        CurrentGroup.Triangles.Add(NewTri);
                        break;
                    default:
                        break;
                }
            }

            FinalizeLoad();

            // Automatically set the room number.
            RootNode.RoomNumber = roomIndex;

            // Copy the room table index used by the original collision mesh's root node to all of the groups loaded from the dae.
            // This isn't perfect because some rooms (like dungeon hub rooms) have different collision groups using different room tables, and this method doesn't preserve that.
            // But this does work much better than not setting the room table index at all.
            foreach (CollisionGroupNode node in m_Nodes)
            {
                node.RoomTableIndex = roomTableIndex;
            }
        }

        private CollisionGroupNode LoadGroupsFromColladaRecursive(CollisionGroupNode parent, node dae_node, geometry[] meshes)
        {
            CollisionGroupNode new_node = new CollisionGroupNode(parent, dae_node.name);
            m_Nodes.Add(new_node);

            if (dae_node.instance_geometry != null)
            {
                string mesh_id = dae_node.instance_geometry[0].url.Trim('#');
                geometry node_geo = Array.Find(meshes, x => x.id == mesh_id);

                LoadGeometryFromCollada(new_node, node_geo);
            }

            if (dae_node.node1 != null)
            {
                foreach (node n in dae_node.node1)
                {
                    new_node.Children.Add(LoadGroupsFromColladaRecursive(new_node, n, meshes));
                }
            }

            return new_node;
        }

        private void LoadGeometryFromCollada(CollisionGroupNode parent, geometry geo)
        {
            mesh m = geo.Item as mesh;

            // For safety, read the model's definition of where the position data is
            // and grab it from there. We could just do a search for "position" in the
            // source list names, but this makes sure there are no errors.
            InputLocal pos_input = Array.Find(m.vertices.input, x => x.semantic == "POSITION");
            source pos_src = Array.Find(m.source, x => x.id == pos_input.source.Trim('#'));
            float_array pos_arr = pos_src.Item as float_array;

            // For some reason Maya puts a leading space in the face index data,
            // so we need to trim that out before trying to parse the index string.
            string[] indices;
            int stride;
            if (m.Items[0].GetType() == typeof(triangles))
            {
                triangles tris = m.Items[0] as triangles;
                indices = tris.p.Trim(' ').Split(' ');
                stride = tris.input.Length; // Make sure this tool can support meshes with multiple vertex attributes.
            }
            else if (m.Items[0].GetType() == typeof(polylist))
            {
                polylist polys = m.Items[0] as polylist;
                indices = polys.p.Trim(' ').Split(' ');
                stride = polys.input.Length; // Make sure this tool can support meshes with multiple vertex attributes.
            }
            else
            {
                throw new Exception($"Unsupported polygon type for mesh {geo.name}: {m.Items[0].GetType()}");
            }

            for (int i = 0; i < indices.Length; i += stride * 3)
            {
                int vec1_index = Convert.ToInt32(indices[i]);
                int vec2_index = Convert.ToInt32(indices[i + stride]);
                int vec3_index = Convert.ToInt32(indices[i + (stride * 2)]);

                Vector3 vec1 = new Vector3((float)pos_arr.Values[vec1_index * 3],
                                           (float)pos_arr.Values[(vec1_index * 3) + 1],
                                           (float)pos_arr.Values[(vec1_index * 3) + 2]);

                Vector3 vec2 = new Vector3((float)pos_arr.Values[vec2_index * 3],
                                           (float)pos_arr.Values[(vec2_index * 3) + 1],
                                           (float)pos_arr.Values[(vec2_index * 3) + 2]);

                Vector3 vec3 = new Vector3((float)pos_arr.Values[vec3_index * 3],
                                           (float)pos_arr.Values[(vec3_index * 3) + 1],
                                           (float)pos_arr.Values[(vec3_index * 3) + 2]);

                // The benefit of using this library is that we easily got the up-axis
                // info from the file. If the up-axis was defined as Z-up, we need to
                // swap the Y and Z components of our vectors so the mesh isn't sideways.
                // (The Wind Waker is Y-up.)
                if (m_UpAxis == UpAxisType.Z_UP)
                {
                    vec1 = SwapYZ(vec1);
                    vec2 = SwapYZ(vec2);
                    vec3 = SwapYZ(vec3);
                }

                CollisionTriangle new_tri = new CollisionTriangle(vec1, vec2, vec3, parent);

                parent.Triangles.Add(new_tri);
                Triangles.Add(new_tri);
            }
        }

        private Vector3 SwapYZ(Vector3 vec)
        {
            Vector3 new_vec = vec;

            float temp = -new_vec.Y;
            new_vec.Y = new_vec.Z;
            new_vec.Z = temp;

            return new_vec;
        }
        #endregion

        private void FinalizeLoad()
        {
            m_Colors_Black = new Vector4[TriangleCount * 3];

            // Generate vertex buffer and index buffer for drawing
            m_Indices = new int[TriangleCount * 3];
            m_Vertices = new Vector3[TriangleCount * 3];

            for (int i = 0; i < Triangles.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int cur_index = (i * 3) + j;
                    m_Indices[cur_index] = cur_index;
                    m_Vertices[cur_index] = Triangles[i].Vertices[j];
                }
            }

            CalculateAABB();
            SetupGL();
        }

        private void CalculateAABB()
        {
            Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
            Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);

            for (int i = 0; i < m_Vertices.Length; i++)
            {
                if (m_Vertices[i].X < min.X) min.X = m_Vertices[i].X;
                if (m_Vertices[i].Y < min.Y) min.Y = m_Vertices[i].Y;
                if (m_Vertices[i].Z < min.Z) min.Z = m_Vertices[i].Z;

                if (m_Vertices[i].X > max.X) max.X = m_Vertices[i].X;
                if (m_Vertices[i].Y > max.Y) max.Y = m_Vertices[i].Y;
                if (m_Vertices[i].Z > max.Z) max.Z = m_Vertices[i].Z;
            }

            m_aaBox = new FAABox(min, max);
        }
    }
}
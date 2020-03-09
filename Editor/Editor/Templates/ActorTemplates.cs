﻿// 
using GameFormatReader.Common;
using OpenTK;
using System.ComponentModel;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using WindEditor.ViewModel;

namespace WindEditor
{
	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class acorn_leaf : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("acorn_leaf", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public acorn_leaf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class agbsw0 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("agbsw0", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FFFF | (value_as_int << 0 & 0x0000FFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("agbsw0", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("agbsw0", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("agbsw0", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFF0000 | (value_as_int << 16 & 0xFFFF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("agbsw0", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("agbsw0", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public agbsw0(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class alldie : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("alldie", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public alldie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class am : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Wandering = 0,
			Guards_an_area = 1,
		}

		[WProperty("am", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("am", "Guarded Area Radius (Hundreds)", true, "", SourceScene.Room)]
		public int GuardedAreaRadiusHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("GuardedAreaRadiusHundreds");
			}
		}

		[WProperty("am", "Switch Activates Armos Knight?", true, "If this is checked, the switch below is for activating the Armos Knight, rather than for disabling the Armos Knight's Spawn.", SourceScene.Room)]
		public bool SwitchActivatesArmosKnight
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SwitchActivatesArmosKnight");
			}
		}

		[WProperty("am", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public am(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class am2 : Actor
	{
		// Auto-Generated Properties from Templates
		public int Unused_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unused_1");
			}
		}

		[WProperty("am2", "Sight Range (Hundreds)", true, "This number multiplied by 100 is the range it can see Link within.", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("am2", "Switch Activates Armos?", true, "If this is checked, the switch below is for activating the Armos Knight, rather than for disabling the Armos's Spawn.", SourceScene.Room)]
		public bool SwitchActivatesArmos
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SwitchActivatesArmos");
			}
		}

		[WProperty("am2", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public am2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class amiprop : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("amiprop", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("amiprop", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public amiprop(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class andsw0 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("andsw0", "Num Switches to Check", true, "How many switches to check.", SourceScene.Room)]
		public int NumSwitchestoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("NumSwitchestoCheck");
			}
		}

		public enum TypeEnum
		{
			Normal = 0,
			Check_for_unset_after_set = 1,
			Time_limit_check = 2,
			Normal_with_65_frames_delayed_set = 3,
			Normal_B = 255,
		}

		[WProperty("andsw0", "Type", true, "'Normal' just checks all the switches it should and then sets 'Switch to Set'.\n'Check for unset after set' does the same, but if any of the switches to check are ever unset, 'Switch to Set' will also be unset.\n'Time limit check' starts a time limit once the first switch to check has been set, you must set the other ones within it.\n'Normal with 65 frames delayed set' waits 65 frames after the last switch to check is set before setting 'Switch to Set'.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("andsw0", "First Switch to Check", true, "The first switch index to check. If this is 0, use (Switch to Set + 1) as the first switch to check instead.\nThe other switches it checks are sequential after the first one. For example, if the first switch is 5, and 'Num Switches to Check' is 3, it will check switches 5, 6, and 7.", SourceScene.Room)]
		public int FirstSwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("FirstSwitchtoCheck");
			}
		}

		[WProperty("andsw0", "Switch to Set", true, "The switch to be set once all the switches to check have been set.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("andsw0", "Event", true, "The event to start once all the switches to check have been set.", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Event");
			}
		}

		[WProperty("andsw0", "Time Limit (Half Seconds)", true, "For the 'Time limit check' type, this number times 15 frames is how long the player has to set all the switches after the first switch is set.", SourceScene.Room)]
		public int TimeLimitHalfSeconds
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("TimeLimitHalfSeconds");
			}
		}

		// Constructor
		public andsw0(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class andsw2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("andsw2", "Num Switches to Check", true, "", SourceScene.Room)]
		public int NumSwitchestoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("NumSwitchestoCheck");
			}
		}

		[WProperty("andsw2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("andsw2", "Switch to Set", true, "The switch to be set once all the switches to check have been set.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("andsw2", "First Switch to Check", true, "The first switch index to check. The other switches it checks are after this one sequentially.\nFor example, if this is 5 and 'Num Switches to Check' is 3, it will check switches 5, 6, and 7.", SourceScene.Room)]
		public int FirstSwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("FirstSwitchtoCheck");
			}
		}

		[WProperty("andsw2", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("andsw2", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public andsw2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class arrow_iceeff : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public arrow_iceeff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class arrow_lighteff : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("arrow_lighteff", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public arrow_lighteff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class atdoor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("atdoor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public atdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class att : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("att", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public att(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class auction : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public auction(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bb : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Flying_around = 0,
			Instantly_targets_Link = 3,
			Sits_in_place_A = 4,
			Carrying_a_Moblin = 5,
			Carrying_a_Bokoblin = 6,
			Sits_in_place_B = 7,
		}

		[WProperty("bb", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("bb", "Sight Range (Hundreds)", true, "", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("bb", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("bb", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("bb", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public bb(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bdk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bdk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bdk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bdkobj : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bdkobj", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bdkobj", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public bdkobj(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class beam : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("beam", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("beam", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("beam", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("beam", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("beam", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x10000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x10000000 | (value_as_int << 28 & 0x10000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("beam", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x30000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x30000000 | (value_as_int << 28 & 0x30000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("beam", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xC0000000) >> 30);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xC0000000 | (value_as_int << 30 & 0xC0000000));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("beam", "Unknown_8", true, "", SourceScene.Room)]
		public int Unknown_8
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_8");
			}
		}

		// Constructor
		public beam(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bflower : Actor
	{
		// Auto-Generated Properties from Templates
		public int FlowerType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("FlowerType");
			}
		}

		[WProperty("bflower", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public bflower(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bgn : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bgn", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bgn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bgn2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public bgn2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bgn3 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public bgn3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bigelf : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bigelf", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bigelf", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bigelf", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bigelf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bita : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bita", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bita", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public bita(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bk : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Wandering = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Hiding_in_a_Pot = 3,
			Guarding = 4,
			Being_carried_by_a_Kargaroc = 5,
			Search_Light_Operator = 6,
			Jumping = 7,
			Guarding_and_Yawning = 10,
			Pink_Bokoblin_with_Telescope = 11,
			Debug = 15,
		}

		[WProperty("bk", "Type", true, "The behavior of the Bokoblin when it spawns.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("bk", "Switch Spawns Bokoblin", true, "If this is set, the switch ID below is for spawning the Bokoblin, rather than a switch to set when it's killed.", SourceScene.Room)]
		public bool SwitchSpawnsBokoblin
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000010) >> 4);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00000010 | (value_as_int << 4 & 0x00000010));
				OnPropertyChanged("SwitchSpawnsBokoblin");
			}
		}

		[WProperty("bk", "Is Green", true, "If this is set, the Bokoblin is green. However, this is overriden by the Pink Bokoblin with Telescope type.", SourceScene.Room)]
		public bool IsGreen
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000020) >> 5);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00000020 | (value_as_int << 5 & 0x00000020));
				OnPropertyChanged("IsGreen");
			}
		}

		public enum WeaponEnum
		{
			Unlit_Torch = 0,
			Machete_1 = 1,
			Lit_Torch = 2,
			Machete_2 = 3,
		}

		[WProperty("bk", "Weapon", true, "The weapon that the Bokoblin is holding when it spawns.", SourceScene.Room)]
		public WeaponEnum Weapon
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000C0) >> 6);
				return (WeaponEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000C0 | (value_as_int << 6 & 0x000000C0));
				OnPropertyChanged("Weapon");
			}
		}

		[WProperty("bk", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("bk", "Path", true, "The path that the Bokoblin follows.", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("bk", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("bk", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public bk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bl : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Red_Bubble = 0,
			Blue_Bubble = 1,
			Path_Following_Red_Bubble = 2,
			Path_Following_Blue_Bubble = 3,
			Inanimate_Skull = 128,
		}

		[WProperty("bl", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("bl", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("bl", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("bl", "Float at Initial Height?", true, "If this is not checked, the Bubble will float near the ground below it instead of in the air where it is actually placed.", SourceScene.Room)]
		public bool FloatatInitialHeight
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("FloatatInitialHeight");
			}
		}

		// Constructor
		public bl(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bmd : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public bmd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bmdfoot : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bmdfoot", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bmdfoot(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bmdhand : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bmdhand", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bmdhand", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bmdhand", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000001F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000001F | (value_as_int << 0 & 0x0000001F));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bmdhand(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bo : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Normal = 0,
			Bud_dying = 1,
			Head_and_stem_dying = 2,
			Bugged_and_invisible = 3,
		}

		[WProperty("bo", "Type", true, "Use the 'Normal' type. The two dying types are spawned by it automatically when it dies.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("bo", "Leave Behind Baba Bud?", true, "", SourceScene.Room)]
		public bool LeaveBehindBabaBud
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("LeaveBehindBabaBud");
			}
		}

		// Constructor
		public bo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class boko : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("boko", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x3FFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x3FFFFFFF | (value_as_int << 0 & 0x3FFFFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("boko", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("boko", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public boko(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class boss_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("boss_item", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public boss_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bpw : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bpw", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bpw", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bpw", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public bpw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class branch : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public branch(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bridge : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bridge", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("bridge", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("bridge", "Path", true, "The path for the bridge to be stretched along.", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public bridge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bst : Actor
	{
		// Auto-Generated Properties from Templates
		public int ComponentType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ComponentType");
			}
		}

		// Constructor
		public bst(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class btd : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public btd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bwd : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bwd", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bwd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bwdg : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public bwdg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class bwds : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("bwds", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public bwds(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class canon : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("canon", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public canon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class cc : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Normal = 0,
			Falls_from_ceiling = 1,
			Bugged_and_does_not_appear = 2,
			Random_movement = 3,
			Hiding_in_pot = 4,
		}

		[WProperty("cc", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		public enum ColorTypeEnum
		{
			Green = 0,
			Red = 1,
			Blue = 2,
			Dark = 3,
			Yellow = 4,
			Green_and_attacks_instantly = 10,
			Red_and_attacks_instantly = 11,
			Blue_and_attacks_instantly = 12,
			Dark_and_attacks_instantly = 13,
			Yellow_and_attacks_instantly = 14,
			Red_and_attacks_instantly_and_more_vulnerabilities = 15,
		}

		[WProperty("cc", "Color Type", true, "The 'attacks instantly' types are used by Wizzrobes. The 'attacks instantly and more vulnerabilities' type can die from Boomerang/Grappling Hook/Hookshot for some reason, but this type is unused.", SourceScene.Room)]
		public ColorTypeEnum ColorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return (ColorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("ColorType");
			}
		}

		[WProperty("cc", "Sight Range (Tens)", true, "", SourceScene.Room)]
		public int SightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SightRangeTens");
			}
		}

		[WProperty("cc", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		// Constructor
		public cc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class coming2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public coming2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class coming3 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public coming3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dai : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("dai", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public dai(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class daiocta : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("daiocta", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("daiocta", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("daiocta", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("daiocta", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("daiocta", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public daiocta(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class daiocta_eye : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public daiocta_eye(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class deku_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("Deku Leaf Pickup", "Item Pickup Flag", true, "", SourceScene.Room)]
		public int ItemPickupFlag
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("ItemPickupFlag");
			}
		}

		// Constructor
		public deku_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class demo_dk : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public demo_dk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class demo_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("demo_item", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("demo_item", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public demo_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class demo_kmm : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public demo_kmm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("dk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public dk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class door10 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("Door", "Switch 1", true, "For normal-type doors, this is the switch it will check and unlock itself once it's set.\nFor barred-type doors, this is the switch it will set when all enemies are dead.", SourceScene.Room)]
		public int Switch1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Switch1");
				UpdateModel();
			}
		}

		public enum TypeEnum
		{
			Normal = 0,
			Boss = 1,
			Barred_until_all_enemies_dead = 2,
			Unknown = 3,
			Locked = 4,
			Locked_and_barred = 5,
		}

		[WProperty("Door", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Type");
				UpdateModel();
			}
		}

		[WProperty("Door", "Event ID", true, "", SourceScene.Room)]
		public int EventID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("EventID");
			}
		}

		[WProperty("Door", "Switch 2", true, "", SourceScene.Room)]
		public int Switch2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("Switch2");
			}
		}

		[WProperty("Door", "From Room Number", true, "", SourceScene.Room)]
		public int FromRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("FromRoomNumber");
			}
		}

		[WProperty("Door", "To Room Number", true, "", SourceScene.Room)]
		public int ToRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x0FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x0FC0 | (value_as_int << 6 & 0x0FC0));
				OnPropertyChanged("ToRoomNumber");
			}
		}

		[WProperty("Door", "Ship ID", true, "", SourceScene.Room)]
		public int ShipID
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("ShipID");
			}
		}

		[WProperty("Door", "Arg 1", true, "", SourceScene.Room)]
		public int Arg1
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Arg1");
			}
		}

		// Constructor
		public door10(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class door12 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("Door", "Switch 1", true, "For normal-type doors, this is the switch it will check and unlock itself once it's set.\nFor barred-type doors, this is the switch it will set when all enemies are dead.", SourceScene.Room)]
		public int Switch1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Switch1");
			}
		}

		public enum TypeEnum
		{
			Normal = 0,
			Boss = 1,
			Barred_until_all_enemies_dead = 2,
			Unknown_3 = 3,
			Locked = 4,
		}

		[WProperty("Door", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Door", "Event ID", true, "", SourceScene.Room)]
		public int EventID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("EventID");
			}
		}

		[WProperty("Door", "Switch 2", true, "", SourceScene.Room)]
		public int Switch2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("Switch2");
			}
		}

		[WProperty("Door", "From Room Number", true, "", SourceScene.Room)]
		public int FromRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("FromRoomNumber");
			}
		}

		[WProperty("Door", "To Room Number", true, "", SourceScene.Room)]
		public int ToRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x0FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x0FC0 | (value_as_int << 6 & 0x0FC0));
				OnPropertyChanged("ToRoomNumber");
			}
		}

		[WProperty("Door", "Ship ID", true, "", SourceScene.Room)]
		public int ShipID
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("ShipID");
			}
		}

		[WProperty("Door", "Arg 1", true, "", SourceScene.Room)]
		public int Arg1
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Arg1");
			}
		}

		// Constructor
		public door12(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dr : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public dr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dr2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public dr2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class dummy : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public dummy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ep : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Has_brazier_1 = 0,
			Does_not_have_brazier_1 = 1,
			Does_not_have_brazier_2 = 2,
			Has_brazier_2 = 3,
		}

		[WProperty("ep", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("ep", "Has Fireflies?", true, "", SourceScene.Room)]
		public bool HasFireflies
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000040) >> 6);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00000040 | (value_as_int << 6 & 0x00000040));
				OnPropertyChanged("HasFireflies");
			}
		}

		[WProperty("Torch", "Is Wooden?", true, "If this is true and the Torch Type is brazier, the brazier is wooden instead of gold.", SourceScene.Room)]
		public bool IsWooden
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000080) >> 7);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00000080 | (value_as_int << 7 & 0x00000080));
				OnPropertyChanged("IsWooden");
			}
		}

		[WProperty("ep", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("ep", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("Torch", "On Switch", true, "The ID of the switch that, when set, lights the torch. If -1, the torch is lit by default.", SourceScene.Room)]
		public int OnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("OnSwitch");
			}
		}

		// Constructor
		public ep(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fallrock : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public fallrock(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fallrock_tag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fallrock_tag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public fallrock_tag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fan : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fan", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("fan", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public fan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ff : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ff", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ff", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ff", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFF00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFF00FF | (value_as_int << 0 & 0xFFFF00FF));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fganon : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fganon", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("fganon", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("fganon", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("fganon", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("fganon", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public fganon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fgmahou : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fgmahou", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public fgmahou(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fire : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fire", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("fire", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("fire", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0001F000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0001F000 | (value_as_int << 12 & 0x0001F000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("fire", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000E0000) >> 17);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000E0000 | (value_as_int << 17 & 0x000E0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("fire", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public fire(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class floor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("floor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public floor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class fm : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("fm", "Link Captured Exit", true, "Which exit this Floormaster takes Link through when it captures him.", SourceScene.Room)]
		public ExitData LinkCapturedExit
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<ExitData> list = cur_object.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("LinkCapturedExit");
			}
		}

		public enum TypeEnum
		{
			Stalker_unused = 0,
			Follows_path = 1,
			Doesnt_follow_path = 2,
		}

		[WProperty("fm", "Type", true, "The unused Stalker type follows Link without coming out of the floor. That type only appears when its Enable Spawn Switch is set while in the same room as the Floormaster.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("Type");
			}
		}

		public enum TargetingBehaviorTypeEnum
		{
			Target_Link_and_partner = 0,
			Target_Link_only = 1,
			Target_Partner_only = 2,
		}

		[WProperty("fm", "Targeting Behavior Type", true, "", SourceScene.Room)]
		public TargetingBehaviorTypeEnum TargetingBehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000C00) >> 10);
				return (TargetingBehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000C00 | (value_as_int << 10 & 0x00000C00));
				OnPropertyChanged("TargetingBehaviorType");
			}
		}

		[WProperty("fm", "Path", true, "Only the \"Follows path\" type uses this path.", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("fm", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("fm", "Disable Spawn Switch", true, "", SourceScene.Room)]
		public int DisableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnSwitch");
			}
		}

		[WProperty("fm", "Partner Captured Exit", true, "Which stage exit this Floormaster takes Medli/Makar through when it captures them.", SourceScene.Stage)]
		public ExitData PartnerCapturedExit
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<ExitData> list = stage.GetChildrenOfType<ExitData>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<ExitData> list = stage.GetChildrenOfType<ExitData>();
				int value_as_int = list.IndexOf(value);
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("PartnerCapturedExit");
			}
		}

		[WProperty("fm", "Sight Range (Hundreds)", true, "Defaults to a range of 3000 if you set this to 0 or 255.", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		// Constructor
		public fm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class f_pc_profile_lst : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public f_pc_profile_lst(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ghostship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ghostship", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ghostship", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ghostship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gm : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("gm", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("gm", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("gm", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("gm", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("gm", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public gm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gnd : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("gnd", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("gnd", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public gnd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class goal_flag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("goal_flag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("goal_flag", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public goal_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class grass : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("grass", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("grass", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000030) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000030 | (value_as_int << 4 & 0x00000030));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("grass", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000FC0 | (value_as_int << 6 & 0x00000FC0));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public grass(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gy : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public gy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class gy_ctrl : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Follows_you_across_sectors = 0,
			Stays_in_sector = 1,
		}

		[WProperty("gy_ctrl", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("gy_ctrl", "Number of Gyorgs", true, "How many Gyorgs to spawn. 15 defaults to 1 Gyorg.", SourceScene.Room)]
		public int NumberofGyorgs
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("NumberofGyorgs");
			}
		}

		[WProperty("gy_ctrl", "Sight Range (Thousands)", true, "This number multiplied by 1000 is the range it can see KoRL within and will start spawning Gyorgs.", SourceScene.Room)]
		public int SightRangeThousands
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeThousands");
			}
		}

		[WProperty("gy_ctrl", "Enable Spawn Switch", true, "If this switch is valid, the spawner will not start spawning Gyorgs until the switch is set.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public gy_ctrl(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class himo3 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("himo3", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("himo3", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("himo3", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("himo3", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("himo3", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public himo3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hitobj : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("hitobj", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public hitobj(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hmlif : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("hmlif", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("hmlif", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("hmlif", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("hmlif", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00300000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00300000 | (value_as_int << 20 & 0x00300000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("hmlif", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07C00000) >> 22);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x07C00000 | (value_as_int << 22 & 0x07C00000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("hmlif", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x78000000) >> 27);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x78000000 | (value_as_int << 27 & 0x78000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("hmlif", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("hmlif", "Unknown_8", true, "", SourceScene.Room)]
		public int Unknown_8
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_8");
			}
		}

		// Constructor
		public hmlif(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hot_floor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("hot_floor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("hot_floor", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000002) >> 1);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000002 | (value_as_int << 1 & 0x00000002));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public hot_floor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class hys : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("hys", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("hys", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public hys(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class icelift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("icelift", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("icelift", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000FF0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000FF0 | (value_as_int << 4 & 0x00000FF0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("icelift", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public icelift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ikari : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ikari", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ikari", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ikari(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("Item Pickup", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class jbo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("jbo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public jbo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kaji : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public kaji(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kamome : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kamome", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kamome", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kamome", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("kamome", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public kamome(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kanban : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kanban", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFF00000 | (value_as_int << 20 & 0xFFF00000));
				OnPropertyChanged("Unknown_1");
			}
		}

		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FFFF | (value_as_int << 0 & 0x0000FFFF));
				OnPropertyChanged("MessageID");
			}
		}

		// Constructor
		public kanban(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kantera : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kantera", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kantera", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kantera", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public kantera(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kb : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kb", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kb", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kb", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("kb", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("kb", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public kb(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kddoor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("Door", "Switch Bit", true, "", SourceScene.Room)]
		public int SwitchBit
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchBit");
			}
		}

		[WProperty("Door", "Type", true, "", SourceScene.Room)]
		public int Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("Door", "Event ID", true, "", SourceScene.Room)]
		public int EventID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("EventID");
			}
		}

		[WProperty("Door", "Switch Bit 2", true, "", SourceScene.Room)]
		public int SwitchBit2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("SwitchBit2");
			}
		}

		[WProperty("Door", "From Room Number", true, "", SourceScene.Room)]
		public int FromRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("FromRoomNumber");
			}
		}

		[WProperty("Door", "To Room Number", true, "", SourceScene.Room)]
		public int ToRoomNumber
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x0FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x0FC0 | (value_as_int << 6 & 0x0FC0));
				OnPropertyChanged("ToRoomNumber");
			}
		}

		[WProperty("Door", "Ship ID", true, "", SourceScene.Room)]
		public int ShipID
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("ShipID");
			}
		}

		[WProperty("Door", "Arg 1", true, "", SourceScene.Room)]
		public int Arg1
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Arg1");
			}
		}

		// Constructor
		public kddoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ki : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Hanging_from_ceiling = 0,
			Flying_around = 1,
			Launch_forward_on_spawn = 2,
			Immediately_targets_Link = 3,
			Instantly_dies_twice = 30,
			Hanging_from_ceiling_passive = 128,
		}

		[WProperty("ki", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		public enum SightRangeEnum
		{
			_300 = 0,
			_800 = 1,
			_1500 = 2,
			_3000 = 3,
			_3000_B = 127,
		}

		[WProperty("ki", "Sight Range", true, "", SourceScene.Room)]
		public SightRangeEnum SightRange
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00007F00) >> 8);
				return (SightRangeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00007F00 | (value_as_int << 8 & 0x00007F00));
				OnPropertyChanged("SightRange");
			}
		}

		[WProperty("ki", "Is Fire Keese?", true, "", SourceScene.Room)]
		public bool IsFireKeese
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00008000) >> 15);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00008000 | (value_as_int << 15 & 0x00008000));
				OnPropertyChanged("IsFireKeese");
			}
		}

		[WProperty("ki", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("ki", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public ki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kita : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kita", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kita", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public kita(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class klft : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("klft", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("klft", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("klft", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public klft(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kmon : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public kmon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kn : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kn", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kn", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public kn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class knob00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("knob00", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public knob00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kokiie : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kokiie", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kokiie", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public kokiie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class komore : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public komore(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ks : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Group_that_chases_player = 0,
			Group_that_stays_put = 1,
			Single_Morth_that_stays_put = 2,
			Single_Morth_that_chases_player = 3,
			Unknown_1 = 4,
			Unknown_2 = 5,
			Group_in_a_pot = 6,
		}

		[WProperty("ks", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("ks", "Number in Group", true, "The number of Morths in this group. If you set this to 0 or higher than 21 it will just be a single Morth instead.", SourceScene.Room)]
		public int NumberinGroup
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("NumberinGroup");
			}
		}

		[WProperty("ks", "Pot Sight Range (Tens)", true, "This number multiplied by 10 is the range around the pot the Morths are in that they'll notice the player and break out of the pot.", SourceScene.Room)]
		public int PotSightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("PotSightRangeTens");
			}
		}

		// Constructor
		public ks(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kt : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kt", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kui : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kui", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kui", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kui", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("kui", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public kui(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag00", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kytag00", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kytag00", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("kytag00", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("kytag00", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("kytag00", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("kytag00", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public kytag00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag01 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public kytag01(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag02 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag02", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag02(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag03 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag03", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag03(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag04 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag04", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("kytag04", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("kytag04", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public kytag04(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag05 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag05", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag05(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag06 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public kytag06(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class kytag07 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("kytag07", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public kytag07(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lamp : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("lamp", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public lamp(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lbridge : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("lbridge", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public lbridge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class leaflift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("leaflift", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public leaflift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lod_bg : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public lod_bg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lstair : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("lstair", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public lstair(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class lwood : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public lwood(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class machine : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("machine", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public machine(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class magma : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public magma(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class majuu_flag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("majuu_flag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("majuu_flag", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public majuu_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mant : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mant", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public mant(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mbdoor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mbdoor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mbdoor", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mbdoor", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public mbdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mdoor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mdoor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mdoor", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mdoor", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("mdoor", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public mdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mflft : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mflft", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mflft", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public mflft(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mgameboard : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public mgameboard(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mmusic : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public mmusic(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mo2 : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Blue_skin_without_lantern = 0,
			Brown_skin_with_lantern = 1,
			Carried_through_the_air = 5,
			Frozen_in_time = 15,
			Blue_skin_without_lantern_unused = 100,
		}

		[WProperty("mo2", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		public enum FrozeninTimePoseEnum
		{
			Attacking_pose = 0,
			Walking_pose = 1,
		}

		[WProperty("mo2", "Frozen in Time Pose", true, "", SourceScene.Room)]
		public FrozeninTimePoseEnum FrozeninTimePose
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return (FrozeninTimePoseEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("FrozeninTimePose");
			}
		}

		[WProperty("mo2", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("mo2", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("mo2", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public mo2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class movie_player : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public movie_player(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mozo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mozo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public mozo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class msw : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("msw", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public msw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mt : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mt", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("mt", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00007F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00007F00 | (value_as_int << 8 & 0x00007F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("mt", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00008000) >> 15);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00008000 | (value_as_int << 15 & 0x00008000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("mt", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("mt", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("mt", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public mt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class mtoge : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("mtoge", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public mtoge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ac1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ac1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ac1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ac1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ah : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ah", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ah", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ah(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_aj1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_aj1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_aj1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_aj1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_auction : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_auction(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ba1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ba1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ba1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bj1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bj1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_bj1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_bj1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bm1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bm1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_bm1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_bm1", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_bm1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bmcon1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bmcon1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_bmcon1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bms1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bms1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_bms1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bmsw : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_bmsw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_bs1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_bs1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_bs1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_bs1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_btsw : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_btsw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_btsw2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_btsw2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_btsw2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_cb1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_cb1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_cb1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_co1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_co1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_co1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_de1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_de1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_de1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ds1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ds1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ds1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_gk1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_gk1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_gk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_gp1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_gp1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_gp1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_gp1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_hi1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_hi1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_hi1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ho : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_ho(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_hr : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_hr", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_hr", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_hr", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_hr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_jb1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_jb1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_jb1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ji1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_ji1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kamome : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_kamome", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_kamome", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_kamome(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kf1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_kf1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_kf1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_kf1", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("npc_kf1", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public npc_kf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kg1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_kg1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kg2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_kg2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kk1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_kk1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_kk1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_kk1", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00030000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00030000 | (value_as_int << 16 & 0x00030000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("npc_kk1", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public npc_kk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_km1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_km1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_km1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ko1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ko1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ko1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ko1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_kp1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_kp1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_kp1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ls1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ls1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ls1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_md : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_md", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_md", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_md", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_md(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_mk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_mk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_mk", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_mk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_mn : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_mn", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_mn", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_mn", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_mn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_mt : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_mt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_nz : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_nz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ob1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ob1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_ob1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_ob1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_os : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_os", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_os(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_p1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_p1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_p1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_p1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_p2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_p2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_p2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000003FC) >> 2);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000003FC | (value_as_int << 2 & 0x000003FC));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_p2", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0003FC00) >> 10);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0003FC00 | (value_as_int << 10 & 0x0003FC00));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_p2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_people : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_people", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_people", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("npc_people", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public npc_people(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_pf1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_pf1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_pf1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_pf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_photo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_photo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_photo", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_photo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_pm1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_pm1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_pm1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_roten : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_roten", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_roten", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_roten(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_rsh1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_rsh1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_rsh1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_rsh1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_sarace : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_sarace(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_so : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_so(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_sv : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_sv(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_tc : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_tc", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_tc", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_tc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_tt : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public npc_tt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_uk : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Normal = 1,
			Hiding = 2,
		}

		[WProperty("npc_uk", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("npc_uk", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Path");
			}
		}

		public enum WhichKillerBeeEnum
		{
			Jin = 0,
			Jan = 1,
			JunRoberto = 2,
		}

		[WProperty("npc_uk", "Which Killer Bee", true, "", SourceScene.Room)]
		public WhichKillerBeeEnum WhichKillerBee
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				return (WhichKillerBeeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("WhichKillerBee");
				UpdateModel();
			}
		}

		// Constructor
		public npc_uk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_ym1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_ym1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_ym1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_yw1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_yw1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("npc_yw1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public npc_yw1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_zk1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_zk1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_zk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class npc_zl1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("npc_zl1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public npc_zl1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class nz : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("nz", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("nz", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("nz", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public nz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class nzg : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("nzg", "Sight Range (Fives)", true, "This number multiplied by 5 is the range around the hole it will notice the player and start spawning Rats and/or Bombchus.", SourceScene.Room)]
		public int SightRangeFives
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SightRangeFives");
			}
		}

		[WProperty("nzg", "Maximum Number of Rats", true, "", SourceScene.Room)]
		public int MaximumNumberofRats
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("MaximumNumberofRats");
			}
		}

		public enum TypeEnum
		{
			Spawns_Rats = 0,
			Spawns_Bombchus = 1,
			Spawns_Rats_and_Bombchus = 2,
		}

		[WProperty("nzg", "Type", true, "The type that spawns just Rats also has the Rat Shopkeeper in it.\nThe type that spawns both Rats and Bombchus has a random 50% chance of which to spawn each time it spawns one.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Type");
			}
		}

		public int Unused
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unused");
			}
		}

		// Constructor
		public nzg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_adnno : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_adnno(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ajav : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ajav", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ajav(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ajavw : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_ajavw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_akabe : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_akabe", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_akabe", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_akabe", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00001000 | (value_as_int << 12 & 0x00001000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_akabe", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_akabe(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_apzl : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_apzl", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_apzl(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ashut : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ashut", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_ashut", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_ashut(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_auzu : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_auzu", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_auzu", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_auzu", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_auzu", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_auzu(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_aygr : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_aygr", "Has Ladder", true, "", SourceScene.Room)]
		public bool HasLadder
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("HasLadder");
				UpdateModel();
			}
		}

		// Constructor
		public obj_aygr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_balancelift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_balancelift", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_balancelift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_barrel : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_barrel", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x70000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x70000000 | (value_as_int << 28 & 0x70000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_barrel", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_barrel(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_barrel2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_barrel2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_barrel2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_barrel2", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000400) >> 10);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000400 | (value_as_int << 10 & 0x00000400));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_barrel2", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_barrel2", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x03000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x03000000 | (value_as_int << 24 & 0x03000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_barrel2", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x10000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x10000000 | (value_as_int << 28 & 0x10000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_barrel2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_barrier : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_barrier", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_barrier", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_barrier(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_bemos : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_bemos", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_bemos", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_bemos", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_bemos", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_bemos", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_bemos", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x1FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x1FC0 | (value_as_int << 6 & 0x1FC0));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_bemos(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_bscurtain : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_bscurtain", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_bscurtain(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_buoyflag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_buoyflag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_buoyflag", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_buoyflag", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_buoyflag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_buoyrace : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_buoyrace", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_buoyrace", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_buoyrace(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_cafelmp : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_cafelmp(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_canon : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_canon", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_canon", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_canon", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_canon", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_canon(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_coming : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_coming", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_coming", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000040) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000040 | (value_as_int << 6 & 0x00000040));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_coming", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000700) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000700 | (value_as_int << 8 & 0x00000700));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_coming", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_coming", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x03000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x03000000 | (value_as_int << 24 & 0x03000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_coming", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x30000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x30000000 | (value_as_int << 28 & 0x30000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_coming(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_correct : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_correct", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_correct", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_correct", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_correct", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x40000000) >> 30);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x40000000 | (value_as_int << 30 & 0x40000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_correct(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_demo_barrel : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_demo_barrel(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_dmgroom : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_dmgroom(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_doguu : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_doguu", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_doguu(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_doguu_demo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_doguu_demo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_doguu_demo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_dragonhead : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_dragonhead", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_dragonhead(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_drift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_drift", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_drift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_eayogn : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_eayogn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ebomzo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ebomzo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ebomzo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_eff : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_eff", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_eff(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ekskz : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ekskz", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ekskz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_eskban : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_eskban", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_eskban(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ferris : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ferris", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ferris(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_figure : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_figure", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_figure(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_firewall : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_firewall", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_firewall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_flame : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_flame", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_flame", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00001F00 | (value_as_int << 8 & 0x00001F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_flame", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00006000) >> 13);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00006000 | (value_as_int << 13 & 0x00006000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_flame", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_flame", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x30000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x30000000 | (value_as_int << 28 & 0x30000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_flame", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_flame(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ftree : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ftree", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ftree(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ganonbed : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_ganonbed(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gaship : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gaship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gaship2 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gaship2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gnnbtltaki : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_gnnbtltaki", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_gnnbtltaki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gnndemotakie : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gnndemotakie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gnndemotakis : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gnndemotakis(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gong : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gong(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gryw00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_gryw00", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_gryw00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_gtaki : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_gtaki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hami2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hami2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_hami2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hami3 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hami3", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hami3", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hami3", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_hami3(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hami4 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hami4", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_hami4(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hat : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hat", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_hat(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hbrf1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hbrf1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hbrf1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hbrf1", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_hbrf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hcbh : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hcbh", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hcbh", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00001FC0 | (value_as_int << 6 & 0x00001FC0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hcbh", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x001FE000) >> 13);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x001FE000 | (value_as_int << 13 & 0x001FE000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_hcbh(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hfuck1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_hfuck1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hha : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hha", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hha", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_hha(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hlift : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hlift", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hlift", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000010) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000010 | (value_as_int << 4 & 0x00000010));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_hlift", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_hlift", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_hlift(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hole : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hole", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hole", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_hole(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_homen : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_homen", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000007F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000007F | (value_as_int << 0 & 0x0000007F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_homen", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_homen", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0003F000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0003F000 | (value_as_int << 12 & 0x0003F000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_homen", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x003C0000) >> 18);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x003C0000 | (value_as_int << 18 & 0x003C0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_homen", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public obj_homen(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_homensmoke : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_homensmoke", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_homensmoke", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000002) >> 1);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000002 | (value_as_int << 1 & 0x00000002));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_homensmoke(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_hsehi1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_hsehi1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_hsehi1", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FFFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FFFF00 | (value_as_int << 8 & 0x00FFFF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_hsehi1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_htetu1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_htetu1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_htetu1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ice : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ice", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ice(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_iceisland : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_iceisland", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_iceisland(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ikada : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ikada", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_ikada", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000003F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000003F0 | (value_as_int << 4 & 0x000003F0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_ikada", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0003FC00) >> 10);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0003FC00 | (value_as_int << 10 & 0x0003FC00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_ikada", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_ikada", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x03FC0000) >> 18);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x03FC0000 | (value_as_int << 18 & 0x03FC0000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_ikada", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("obj_ikada", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public obj_ikada(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Itnak : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_Itnak", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_Itnak", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_Itnak(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_jump : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_jump", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_jump(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_kanat : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_kanat", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_kanat(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_kanoke : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_kanoke", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_kanoke", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003E) >> 1);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003E | (value_as_int << 1 & 0x0000003E));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_kanoke", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000040) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000040 | (value_as_int << 6 & 0x00000040));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_kanoke", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_kanoke", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public obj_kanoke(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ladder : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ladder", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_ladder", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_ladder", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_ladder(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_leaves : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_leaves", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_leaves", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001FC0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00001FC0 | (value_as_int << 6 & 0x00001FC0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_leaves", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x001FE000) >> 13);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x001FE000 | (value_as_int << 13 & 0x001FE000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_leaves(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_light : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_light(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_lpalm : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_lpalm(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_magmarock : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_magmarock", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_magmarock", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_magmarock(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_majyuu_door : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_majyuu_door", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_majyuu_door(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mkie : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mkie", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_mkie", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_mkie", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00001000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00001000 | (value_as_int << 12 & 0x00001000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_mkie", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00002000) >> 13);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00002000 | (value_as_int << 13 & 0x00002000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_mkie", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_5");
			}
		}

		// Constructor
		public obj_mkie(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mkiek : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mkiek", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_mkiek", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_mkiek(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mknjd : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mknjd", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_mknjd", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_mknjd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mmrr : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_mmrr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_monument : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_monument", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_monument", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_monument(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_movebox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_movebox", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_movebox", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_movebox", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_movebox", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_movebox", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x40000000) >> 30);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x40000000 | (value_as_int << 30 & 0x40000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_movebox", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_movebox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_msdan", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_msdan", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_msdan", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00040000) >> 18);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00040000 | (value_as_int << 18 & 0x00040000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_msdan", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_msdan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_msdan2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_msdan2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan_sub : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_msdan_sub", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_msdan_sub", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_msdan_sub", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_msdan_sub(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_msdan_sub2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_msdan_sub2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_msdan_sub2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_msdan_sub2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mshokki : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mshokki", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_mshokki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_mtest : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_mtest", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_mtest", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_mtest", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_mtest", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_mtest(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_nest : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_nest(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ohatch : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ohatch", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ohatch(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ojtree : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_ojtree(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ospbox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ospbox", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_ospbox", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000700) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000700 | (value_as_int << 8 & 0x00000700));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_ospbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_otble : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_otble", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_otble(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_paper : Actor
	{
		// Auto-Generated Properties from Templates
		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FFFF | (value_as_int << 0 & 0x0000FFFF));
				OnPropertyChanged("MessageID");
			}
		}

		public int Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("Type");
			}
		}

		// Constructor
		public obj_paper(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pbco : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_pbco(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pbka : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_pbka(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pfall : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_pfall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_pirateship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_pirateship", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_pirateship", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_pirateship", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_pirateship", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_pirateship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_plant : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_plant(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_quake : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_quake", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_quake", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000700) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000700 | (value_as_int << 8 & 0x00000700));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_quake", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00003800) >> 11);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00003800 | (value_as_int << 11 & 0x00003800));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_quake(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_rcloud : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_rcloud", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_rcloud(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_rflw : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_rflw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_rforce : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_rforce(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_roten : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_roten", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_roten(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_shelf : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_shelf", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_shelf", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_shelf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_shmrgrd : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_shmrgrd", "Switch to Set", true, "This switch will be set when the button is pressed.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_shmrgrd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_smplbg : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_smplbg", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_smplbg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_stair : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_stair", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_stair(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swflat : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swflat", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_swflat", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_swflat", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_swflat(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swhammer : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swhammer", "Switch to Unset", true, "This switch will be unset when the button is pressed.", SourceScene.Room)]
		public int SwitchtoUnset
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoUnset");
			}
		}

		[WProperty("obj_swhammer", "Switch to Set", true, "This switch will be set when the button is pressed.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		// Constructor
		public obj_swhammer(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swheavy : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swheavy", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_swheavy", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x07000000 | (value_as_int << 24 & 0x07000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_swheavy(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swlight : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swlight", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_swlight", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_swlight", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public obj_swlight(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_swpush : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_swpush", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_swpush", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_swpush", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_swpush", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x07000000 | (value_as_int << 24 & 0x07000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_swpush", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x40000000) >> 30);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x40000000 | (value_as_int << 30 & 0x40000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_swpush", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public obj_swpush(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_table : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_table", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_table(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tapestry : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tapestry", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tapestry", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tapestry(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tenmado : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tenmado", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tenmado", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tenmado(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tide : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tide", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00070000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00070000 | (value_as_int << 16 & 0x00070000));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tide", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tide(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_timer : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_timer", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_timer", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_timer(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tntrap : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tntrap", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tntrap", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_tntrap", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_tntrap", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00060000) >> 17);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00060000 | (value_as_int << 17 & 0x00060000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_tntrap(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_toripost : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_toripost(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tousekiki : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_tousekiki(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tower : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_tower(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_trap : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_trap", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_trap", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_trap(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_tribox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_tribox", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_tribox", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00010000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00010000 | (value_as_int << 16 & 0x00010000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public obj_tribox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_try : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_try", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_try", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_try", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_try", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFF00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFF00FF | (value_as_int << 0 & 0xFFFF00FF));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public obj_try(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_usovmc : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_usovmc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Vds : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_Vds", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_Vds(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vfan : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_vfan", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vfan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vgnfd : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_vgnfd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vmc : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_vmc", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vmc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vmsdz : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_vmsdz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vmsms : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_vmsms(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_volcano : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_volcano", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_volcano(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Vteng : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_Vteng(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vtil : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_vtil", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vtil(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_vyasi : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_vyasi", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_vyasi(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_warpt : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_warpt", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("obj_warpt", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("obj_warpt", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000FF0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000FF0 | (value_as_int << 4 & 0x00000FF0));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("obj_warpt", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("obj_warpt", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("obj_warpt", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("obj_warpt", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("obj_warpt", "Unknown_8", true, "", SourceScene.Room)]
		public int Unknown_8
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_8");
			}
		}

		[WProperty("obj_warpt", "Unknown_9", true, "", SourceScene.Room)]
		public int Unknown_9
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Unknown_9");
			}
		}

		[WProperty("obj_warpt", "Unknown_10", true, "", SourceScene.Room)]
		public int Unknown_10
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_10");
			}
		}

		[WProperty("obj_warpt", "Unknown_11", true, "", SourceScene.Room)]
		public int Unknown_11
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Unknown_11");
			}
		}

		// Constructor
		public obj_warpt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_wood : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_wood(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_xfuta : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public obj_xfuta(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_Yboil : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_Yboil", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_Yboil(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_ygush00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_ygush00", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000007) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000007 | (value_as_int << 0 & 0x00000007));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_ygush00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_YLzou : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_YLzou", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_YLzou(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class obj_zouK : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("obj_zouK", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public obj_zouK(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class oq : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Freshwater_Octorok = 0,
			Saltwater_Octorok_that_shoots_at_a_certain_range = 1,
			Saltwater_Octorok_that_spawns_close_to_player_and_shoots_after_a_certain_delay = 2,
			Saltwater_Octorok_spawner = 3,
			Saltwater_Octorok_that_shoots_after_a_certain_delay = 4,
			Spawned_saltwater_Octorok = 5,
			Rock_shot_by_a_freshwater_Octorok = 6,
		}

		[WProperty("oq", "Type", true, "The 'Spawned saltwater Octorok' type does not appear when manually placed, it's just for the spawner to create.", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		public enum ProjectileTypeEnum
		{
			Rocks = 0,
			Bombs = 1,
		}

		[WProperty("oq", "Projectile Type", true, "This only affects what freshwater Octoroks shoot, not saltwater ones.", SourceScene.Room)]
		public ProjectileTypeEnum ProjectileType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return (ProjectileTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("ProjectileType");
			}
		}

		[WProperty("oq", "Sight Range (Thousands)", true, "For the 'Saltwater Octorok spawner' type, this number multiplied by 1000 is the range within it will notice the player and start spawning saltwater Octoroks.\nNo effect on other types besides the spawner.", SourceScene.Room)]
		public int SightRangeThousands
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SightRangeThousands");
			}
		}

		// Constructor
		public oq(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class oship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("oship", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("oship", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("oship", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000F000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000F000 | (value_as_int << 12 & 0x0000F000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("oship", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("oship", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("oship", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("oship", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public oship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pedestal : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("pedestal", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public pedestal(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ph : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Peahat = 0,
			Seahat = 1,
		}

		[WProperty("ph", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("ph", "Horizontal Sight Range (Hundreds)", true, "This number multiplied by 100 is the radius of the cylinder it can see Link within. 255 will default to a range of 1000 for Peahats or 12000 for Seahats.", SourceScene.Room)]
		public int HorizontalSightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("HorizontalSightRangeHundreds");
			}
		}

		[WProperty("ph", "Vertical Sight Range (Hundreds)", true, "This number multiplied by 100 is half the height of the cylinder it can see Link within. 255 will default to a range of 500 for Peahats or 6000 for Seahats.", SourceScene.Room)]
		public int VerticalSightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("VerticalSightRangeHundreds");
			}
		}

		// Constructor
		public ph(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pirate_flag : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public pirate_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pt : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Respawning = 0,
			Nonrespawning = 1,
			Nonrespawning_B = 15,
		}

		[WProperty("pt", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("pt", "Initial Miniblin Won't Spawn Onscreen?", true, "If this is checked, the first Miniblin won't spawn until the player's camera is turned away from its spawn point.\n(Miniblins after the first one always act like that regardless of whether this is checked or not.)", SourceScene.Room)]
		public bool InitialMiniblinWontSpawnOnscreen
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000010) >> 4);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00000010 | (value_as_int << 4 & 0x00000010));
				OnPropertyChanged("InitialMiniblinWontSpawnOnscreen");
			}
		}

		public enum RespawnDelayEnum
		{
			_20_frames = 0,
			_40_frames = 1,
			_60_frames = 2,
			_80_frames = 3,
			_100_frames = 4,
			_120_frames = 5,
			_140_frames = 6,
			Use_initial_spawn_delay = 7,
		}

		[WProperty("pt", "Respawn Delay", true, "Number of frames after you kill it before it can respawn.", SourceScene.Room)]
		public RespawnDelayEnum RespawnDelay
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000E0) >> 5);
				return (RespawnDelayEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000E0 | (value_as_int << 5 & 0x000000E0));
				OnPropertyChanged("RespawnDelay");
			}
		}

		[WProperty("pt", "Sight Range (Hundreds)", true, "", SourceScene.Room)]
		public int SightRangeHundreds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeHundreds");
			}
		}

		[WProperty("pt", "Disable Respawn Switch", true, "If this is a valid switch and used with a respawning type Miniblin, this being set stops it from respawning.\nAlternatively, you can also use this with a non-respawning Miniblin, in which case it acts like a 'Deactivate on Death Switch' that it sets on death - but you should only set a temporary switch this way, as if you set a permanent switch the Miniblin will be permanently inactive the next time you enter the room but won't be considered dead.", SourceScene.Room)]
		public int DisableRespawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("DisableRespawnSwitch");
			}
		}

		[WProperty("pt", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("pt", "Initial Spawn Delay", true, "Number of frames after you enter the room before it can spawn the first Miniblin. If setting this to something other than 0, it is recommended to also check 'Initial Miniblin Won't Spawn Onscreen?'. If you don't, then the first Miniblin will be visible before it actually spawns, but simply be deactivated and invincible.", SourceScene.Room)]
		public int InitialSpawnDelay
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("InitialSpawnDelay");
			}
		}

		// Constructor
		public pt(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pw : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Wandering = 0,
			Invisible_until_seeing_Link = 1,
			Invisible_except_Lantern_until_seeing_Link = 2,
			Jalhalla_Poe_A = 3,
			Jalhalla_Poe_B = 4,
		}

		[WProperty("pw", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("pw", "Hovers At Initial Height?", true, "If checked, this Poe will maintain its height in the air like normal. If unchecked, it will slowly float down to the floor.", SourceScene.Room)]
		public bool HoversAtInitialHeight
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000100) >> 8);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return false;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x00000100 | (value_as_int << 8 & 0x00000100));
				OnPropertyChanged("HoversAtInitialHeight");
			}
		}

		public enum ColorEnum
		{
			Blue = 0,
			Purple = 1,
			Orange = 2,
			Yellow = 3,
			Red = 4,
			Green = 5,
		}

		[WProperty("pw", "Color", true, "", SourceScene.Room)]
		public ColorEnum Color
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FE00) >> 9);
				return (ColorEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FE00 | (value_as_int << 9 & 0x0000FE00));
				OnPropertyChanged("Color");
			}
		}

		[WProperty("pw", "Sight Range (Tens)", true, "For the 'Invisible except Lantern until seeing Link' type, this number multiplied by 10 is the range it can see Link within and will materialize. No effect on other types.", SourceScene.Room)]
		public int SightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("SightRangeTens");
			}
		}

		[WProperty("pw", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Path");
			}
		}

		// Constructor
		public pw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class pz : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("pz", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public pz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class race_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("race_item", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("race_item", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00007F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00007F00 | (value_as_int << 8 & 0x00007F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("race_item", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00078000) >> 15);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00078000 | (value_as_int << 15 & 0x00078000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public race_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class rd : Actor
	{
		// Auto-Generated Properties from Templates
		public enum IdleAnimationEnum
		{
			Standing = 0,
			Sitting = 1,
		}

		[WProperty("rd", "Idle Animation", true, "", SourceScene.Room)]
		public IdleAnimationEnum IdleAnimation
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return (IdleAnimationEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("IdleAnimation");
			}
		}

		[WProperty("rd", "Guarded Area Radius", true, "The ReDead has a base radius of 650 and this value is added to that.\nBecause the maximum value here is 127, this doesn't change the size of the area it guards very much.", SourceScene.Room)]
		public int GuardedAreaRadius
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FE) >> 1);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FE | (value_as_int << 1 & 0x000000FE));
				OnPropertyChanged("GuardedAreaRadius");
			}
		}

		[WProperty("rd", "Should Check Switch To Enable Spawn?", true, "If this is checked, the Enable Spawn Switch must be set for the ReDead to spawn.\nIf the Enable Spawn Switch is invalid, then unlike most enemies, this ReDead will never appear instead of always appearing.", SourceScene.Room)]
		public bool ShouldCheckSwitchToEnableSpawn
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0) {
					return false;
				} else if (value_as_int == 0xFF) {
					return true;
				} else {
					return true;
				}
				
			}

			set
			{
				int value_as_int = Convert.ToInt32(value);
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("ShouldCheckSwitchToEnableSpawn");
			}
		}

		[WProperty("rd", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public rd(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class rectangle : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public rectangle(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sail : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public sail(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class saku : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("saku", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("saku", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("saku", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("saku", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public saku(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class salvage : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public salvage(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class salvage_tbox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("salvage_tbox", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("salvage_tbox", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public salvage_tbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sbox : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public sbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class scene_change : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public scene_change(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class seatag : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public seatag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shand : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("shand", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public shand(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ship", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ship", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ship", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shop_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("shop_item", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("shop_item", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public shop_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shutter : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("shutter", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("shutter", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public shutter(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class shutter2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("shutter2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public shutter2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sie_flag : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public sie_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sitem : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("sitem", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("sitem", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("sitem", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("sitem", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public sitem(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("sk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("sk", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public sk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sk2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("sk2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("sk2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("sk2", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public sk2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class spotbox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("spotbox", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000001) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000001 | (value_as_int << 0 & 0x00000001));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public spotbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ss : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ss", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ss", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ss", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ss(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ssk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ssk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ssk", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("ssk", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public ssk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class sss : Actor
	{
		// Auto-Generated Properties from Templates
		public enum SFXTypeEnum
		{
			SFX_58F7 = 0,
			SFX_58F8 = 1,
		}

		[WProperty("sss", "SFX Type", true, "The SFX to play when it comes out of the ground. There's no noticeable difference between the two, so this is a useless parameter.", SourceScene.Room)]
		public SFXTypeEnum SFXType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (SFXTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SFXType");
			}
		}

		[WProperty("sss", "Sight Range (Tens)", true, "This number multiplied by 10 is used as a range within it notices Link and comes out of the ground. 255 will default to a range of 1000.", SourceScene.Room)]
		public int SightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SightRangeTens");
			}
		}

		[WProperty("sss", "Enable Spawn Switch", true, "If this is not 0 or 255, the Dexivine will hide underground until this switch is set.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		// Constructor
		public sss(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class st : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Normal = 0,
			Underground = 1,
			Lying_in_coffin = 2,
			Standing_in_coffin = 3,
			Upper_body = 14,
		}

		[WProperty("st", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("st", "Ambush Sight Range (Tens)", true, "If the Stalfos is underground or in a coffin, this is the range within it will notice the player.", SourceScene.Room)]
		public int AmbushSightRangeTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("AmbushSightRangeTens");
			}
		}

		public int Unused
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unused");
			}
		}

		[WProperty("st", "Ambush Switch", true, "If this is a valid switch and the Stalfos is underground or in a coffin, it will only come out when this switch is set, overriding the normal behave of coming out when the player comes near it.", SourceScene.Room)]
		public int AmbushSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("AmbushSwitch");
			}
		}

		[WProperty("st", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public st(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class steam_tag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("steam_tag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000003FC) >> 2);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000003FC | (value_as_int << 2 & 0x000003FC));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public steam_tag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class stone : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("stone", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("stone", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000C0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000C0 | (value_as_int << 6 & 0x000000C0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("stone", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("stone", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("stone", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x07000000 | (value_as_int << 24 & 0x07000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("stone", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x70000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x70000000 | (value_as_int << 28 & 0x70000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public stone(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class stone2 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("stone2", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("stone2", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("stone2", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("stone2", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x07000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x07000000 | (value_as_int << 24 & 0x07000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("stone2", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x70000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x70000000 | (value_as_int << 28 & 0x70000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("stone2", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public stone2(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swattack : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swattack", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swattack", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public swattack(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swc00 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swc00", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swc00", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("swc00", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00030000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00030000 | (value_as_int << 16 & 0x00030000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public swc00(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swhit0 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swhit0", "Switch to Set", true, "Switch to set when hit.", SourceScene.Room)]
		public int SwitchtoSet
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("SwitchtoSet");
			}
		}

		[WProperty("swhit0", "Event", true, "The event to start when hit? (Only for type 'Unknown 3'.)", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Event");
			}
		}

		public enum TypeEnum
		{
			Unknown_0 = 0,
			Unknown_1 = 1,
			Unknown_2 = 2,
			Unknown_3 = 3,
			Unknown_4 = 4,
			Unknown_4_B = 15,
		}

		[WProperty("swhit0", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("swhit0", "Time Limit (Half Seconds)", true, "This number times 15 frames is how long the player has to hit all the crystals after the first crystal is hit.", SourceScene.Room)]
		public int TimeLimitHalfSeconds
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0FF00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0FF00000 | (value_as_int << 20 & 0x0FF00000));
				OnPropertyChanged("TimeLimitHalfSeconds");
			}
		}

		[WProperty("swhit0", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("swhit0", "Switch to Check", true, "Once this switch is set, the crystal will consider the puzzle finished and no longer be on a timer.", SourceScene.Room)]
		public int SwitchtoCheck
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("SwitchtoCheck");
			}
		}

		// Constructor
		public swhit0(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class switem : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("switem", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("switem", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00003F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00003F00 | (value_as_int << 8 & 0x00003F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("switem", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x001FC000) >> 14);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x001FC000 | (value_as_int << 14 & 0x001FC000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public switem(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swpropeller : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swpropeller", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swpropeller", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public swpropeller(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swtact : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swtact", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swtact", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("swtact", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000F0000 | (value_as_int << 16 & 0x000F0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public swtact(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class swtdoor : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("swtdoor", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("swtdoor", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public swtdoor(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class syan : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public syan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_attention : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_attention", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_attention", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public tag_attention(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_ba1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public tag_ba1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_etc : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_etc", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_etc", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public tag_etc(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_event : Actor
	{
		// Auto-Generated Properties from Templates
		public enum TypeEnum
		{
			Unknown_1 = 0,
			Unknown_2 = 1,
			Unknown_3 = 2,
			Unknown_4 = 3,
			Unknown_5 = 4,
			Unknown_6 = 5,
			Unknown_7 = 6,
			Unknown_8 = 7,
			Unknown_9 = 8,
			Unknown_10 = 9,
			Unknown_11 = 10,
			Unknown_12 = 11,
			Unknown_13 = 12,
			Unknown_14 = 13,
			Normal = 255,
		}

		[WProperty("tag_event", "Type", true, "", SourceScene.Room)]
		public TypeEnum Type
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (TypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Type");
			}
		}

		[WProperty("tag_event", "Set Switch", true, "Switch that this trigger region sets when it triggers the event.", SourceScene.Room)]
		public int SetSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("SetSwitch");
			}
		}

		[WProperty("tag_event", "Enable Spawn Switch", true, "Switch that must be set before this trigger region will become active.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("tag_event", "Event", true, "The event to start when entering this region.", SourceScene.Stage)]
		public MapEvent Event
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WStage stage = World.Map.SceneList.First(x => x.GetType() == typeof(WStage)) as WStage;
				List<MapEvent> list = stage.GetChildrenOfType<MapEvent>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Event");
			}
		}

		[WProperty("tag_event", "Enable Spawn Event Bit", true, "Event bit that must be set before this trigger region will become active.", SourceScene.Room)]
		public int EnableSpawnEventBit
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("EnableSpawnEventBit");
			}
		}

		// Constructor
		public tag_event(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_evsw : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_evsw", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_evsw", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FFFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FFFF00 | (value_as_int << 8 & 0x00FFFF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_evsw", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x03000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x03000000 | (value_as_int << 24 & 0x03000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_evsw(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_ghostship : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_ghostship", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_ghostship", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public tag_ghostship(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_hint : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_hint", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_hint", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000C0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000C0 | (value_as_int << 6 & 0x000000C0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_hint", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_hint", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tag_hint", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("tag_hint", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tag_hint(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_island : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_island", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_island", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_island", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_island(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_kb_item : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_kb_item", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_kb_item", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_kb_item", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_kb_item", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public tag_kb_item(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_kf1 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_kf1", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_kf1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_kk1 : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public tag_kk1(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_light : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_light", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000003) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000003 | (value_as_int << 0 & 0x00000003));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_light", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000300) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000300 | (value_as_int << 8 & 0x00000300));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_light", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000003FC) >> 2);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000003FC | (value_as_int << 2 & 0x000003FC));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_light", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00003C00) >> 10);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00003C00 | (value_as_int << 10 & 0x00003C00));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tag_light", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000C000) >> 14);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000C000 | (value_as_int << 14 & 0x0000C000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("tag_light", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("tag_light", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tag_light(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_md_cb : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_md_cb", "MessageID", true, "", SourceScene.Room)]
		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FFFF | (value_as_int << 0 & 0x0000FFFF));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("tag_md_cb", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_md_cb", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_md_cb", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public tag_md_cb(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_mk : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_mk", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_mk", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_mk", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_mk(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_msg : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_msg", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000C0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000C0 | (value_as_int << 6 & 0x000000C0));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_msg", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_msg", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_msg", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		public int MessageID
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("MessageID");
			}
		}

		[WProperty("tag_msg", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_6");
			}
		}

		// Constructor
		public tag_msg(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_photo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_photo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_photo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_ret : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_ret", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_ret(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_so : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_so", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_so", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_so", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		// Constructor
		public tag_so(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_volcano : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_volcano", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tag_volcano", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000C0) >> 6);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000C0 | (value_as_int << 6 & 0x000000C0));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tag_volcano", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tag_volcano", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public tag_volcano(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tag_waterlevel : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tag_waterlevel", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tag_waterlevel(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tama : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tama", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0xFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0xFFFF | (value_as_int << 0 & 0xFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tama(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tbox : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tbox", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000007F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000007F | (value_as_int << 0 & 0x0000007F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tbox", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F80) >> 7);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F80 | (value_as_int << 7 & 0x00000F80));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tbox", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000FF000) >> 12);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000FF000 | (value_as_int << 12 & 0x000FF000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tbox", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tbox", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x003F | (value_as_int << 0 & 0x003F));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("tbox", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("tbox", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0xFF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0xFF00 | (value_as_int << 8 & 0xFF00));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tbox(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class title : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public title(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tn : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Wandering = 0,
			Guards_an_area = 4,
			Miniboss = 13,
			Drops_down_during_event = 14,
			Frozen_in_time = 15,
		}

		[WProperty("tn", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("BehaviorType");
			}
		}

		public enum ColorEnum
		{
			Silver_and_blue = 0,
			Silver_and_red = 1,
			Gold_and_black = 2,
			White_and_silver = 3,
			Black_and_brown = 4,
			Red_and_gold = 5,
			Red_and_gold_B = 15,
		}

		[WProperty("tn", "Color", true, "", SourceScene.Room)]
		public ColorEnum Color
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000F0) >> 4);
				return (ColorEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000F0 | (value_as_int << 4 & 0x000000F0));
				OnPropertyChanged("Color");
			}
		}

		[WProperty("tn", "Guarded Area Radius (Tens)", true, "", SourceScene.Room)]
		public int GuardedAreaRadiusTens
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("GuardedAreaRadiusTens");
			}
		}

		public enum FrozeninTimePoseEnum
		{
			Walking_pose = 0,
			Attacking_pose = 1,
		}

		[WProperty("tn", "Frozen in Time Pose", true, "", SourceScene.Room)]
		public FrozeninTimePoseEnum FrozeninTimePose
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return (FrozeninTimePoseEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("FrozeninTimePose");
			}
		}

		[WProperty("tn", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Path");
			}
		}

		[WProperty("tn", "Enable Spawn Switch", true, "If this switch is valid, the Darknut will not appear until it is set.", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		public enum ExtraEquipmentEnum
		{
			Normal = 0,
			Helmet = 1,
			Shield = 2,
			Helmet_and_shield = 3,
			Shield_and_cape = 4,
			Helmet_shield_and_cape = 5,
			Helmet_shield_and_cape_B = 7,
		}

		[WProperty("tn", "Extra Equipment", true, "", SourceScene.Room)]
		public ExtraEquipmentEnum ExtraEquipment
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters1 & 0x00E0) >> 5);
				return (ExtraEquipmentEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_AuxillaryParameters1 = (short)(m_AuxillaryParameters1 & ~0x00E0 | (value_as_int << 5 & 0x00E0));
				OnPropertyChanged("ExtraEquipment");
			}
		}

		[WProperty("tn", "Disable Spawn on Death Switch", true, "The Darknut will set this switch when it dies and will not spawn while this is set.", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		// Constructor
		public tn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class toge : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("toge", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("toge", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public toge(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tori_flag : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public tori_flag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tornado : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tornado", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFFFFFFFF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFFFFFFFF | (value_as_int << 0 & 0xFFFFFFFF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public tornado(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tpota : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public tpota(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class tsubo : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("tsubo", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000003F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000003F | (value_as_int << 0 & 0x0000003F));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("tsubo", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00003F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00003F00 | (value_as_int << 8 & 0x00003F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("tsubo", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000C000) >> 14);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000C000 | (value_as_int << 14 & 0x0000C000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("tsubo", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x007F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x007F0000 | (value_as_int << 16 & 0x007F0000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("tsubo", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0F000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0F000000 | (value_as_int << 24 & 0x0F000000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("tsubo", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x70000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x70000000 | (value_as_int << 28 & 0x70000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("tsubo", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x80000000) >> 31);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x80000000 | (value_as_int << 31 & 0x80000000));
				OnPropertyChanged("Unknown_7");
			}
		}

		// Constructor
		public tsubo(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wall : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("wall", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("wall", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public wall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpdm20 : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpdm20", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warpdm20(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpf : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpf", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warpf(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpfout : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public warpfout(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpgn : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpgn", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("warpgn", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public warpgn(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warphr : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warphr", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warphr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpls : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpls", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("warpls", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("warpls", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("warpls", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xF0000000) >> 28);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xF0000000 | (value_as_int << 28 & 0xF0000000));
				OnPropertyChanged("Unknown_4");
			}
		}

		// Constructor
		public warpls(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class warpmj : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("warpmj", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public warpmj(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class waterfall : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("waterfall", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("waterfall", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00000F00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00000F00 | (value_as_int << 8 & 0x00000F00));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public waterfall(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wbird : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public wbird(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class windmill : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("windmill", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public windmill(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wind_tag : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("wind_tag", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("wind_tag", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_2");
			}
		}

		[WProperty("wind_tag", "Unknown_3", true, "", SourceScene.Room)]
		public int Unknown_3
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x001F0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x001F0000 | (value_as_int << 16 & 0x001F0000));
				OnPropertyChanged("Unknown_3");
			}
		}

		[WProperty("wind_tag", "Unknown_4", true, "", SourceScene.Room)]
		public int Unknown_4
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00600000) >> 21);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00600000 | (value_as_int << 21 & 0x00600000));
				OnPropertyChanged("Unknown_4");
			}
		}

		[WProperty("wind_tag", "Unknown_5", true, "", SourceScene.Room)]
		public int Unknown_5
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00800000) >> 23);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00800000 | (value_as_int << 23 & 0x00800000));
				OnPropertyChanged("Unknown_5");
			}
		}

		[WProperty("wind_tag", "Unknown_6", true, "", SourceScene.Room)]
		public int Unknown_6
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Unknown_6");
			}
		}

		[WProperty("wind_tag", "Unknown_7", true, "", SourceScene.Room)]
		public int Unknown_7
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x000F | (value_as_int << 0 & 0x000F));
				OnPropertyChanged("Unknown_7");
			}
		}

		[WProperty("wind_tag", "Unknown_8", true, "", SourceScene.Room)]
		public int Unknown_8
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00F0) >> 4);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00F0 | (value_as_int << 4 & 0x00F0));
				OnPropertyChanged("Unknown_8");
			}
		}

		// Constructor
		public wind_tag(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class wz : Actor
	{
		// Auto-Generated Properties from Templates
		public enum BehaviorTypeEnum
		{
			Shoots_Fireballs = 0,
			Spawns_Enemies_and_Shoots_Fireballs = 1,
			Miniboss = 2,
			Unknown_1 = 3,
			Fireball = 10,
			Spawner_Orb_1 = 12,
			Spawner_Orb_2 = 13,
			Shoots_Fireballs_B = 255,
		}

		[WProperty("wz", "Behavior Type", true, "", SourceScene.Room)]
		public BehaviorTypeEnum BehaviorType
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x000000FF) >> 0);
				return (BehaviorTypeEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_Parameters = (int)(m_Parameters & ~0x000000FF | (value_as_int << 0 & 0x000000FF));
				OnPropertyChanged("BehaviorType");
			}
		}

		[WProperty("wz", "Disable Spawn on Death Switch", true, "", SourceScene.Room)]
		public int DisableSpawnonDeathSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("DisableSpawnonDeathSwitch");
			}
		}

		[WProperty("wz", "Enable Spawn Switch", true, "", SourceScene.Room)]
		public int EnableSpawnSwitch
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00FF0000) >> 16);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00FF0000 | (value_as_int << 16 & 0x00FF0000));
				OnPropertyChanged("EnableSpawnSwitch");
			}
		}

		[WProperty("wz", "Path", true, "", SourceScene.Room)]
		public Path_v2 Path
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0xFF000000) >> 24);
				if (value_as_int == 0xFF) { return null; }
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				if (value_as_int >= list.Count) { return null; }
				return list[value_as_int];
			}

			set
			{
				WDOMNode cur_object = this;
				while (cur_object.Parent != null)
				{
					cur_object = cur_object.Parent;
				}
				List<Path_v2> list = cur_object.GetChildrenOfType<Path_v2>();
				int value_as_int = list.IndexOf(value);
				m_Parameters = (int)(m_Parameters & ~0xFF000000 | (value_as_int << 24 & 0xFF000000));
				OnPropertyChanged("Path");
			}
		}

		public enum EnemySummonTableEnum
		{
			Many_Keese_and_Magtails = 0,
			Many_Keese_and_Red_Bubbles = 1,
			Blue_Bubbles = 2,
			Many_Morths = 3,
			Many_Green_ChuChus = 4,
			Red_and_Blue_Bubbles_and_Poes = 5,
			Stalfos_and_ReDeads = 6,
			Moblins_and_Darknuts = 7,
			Peahats_Keese_and_Kargarocs = 8,
			Keese_and_Magtails = 9,
			Keese_and_Red_Bubbles = 10,
			Morths = 11,
			Green_ChuChus = 12,
			Bokoblins_and_Moblins = 13,
			Kargarocs_Keese_Green_and_Red_ChuChus_and_Morths = 14,
		}

		[WProperty("wz", "Enemy Summon Table", true, "", SourceScene.Room)]
		public EnemySummonTableEnum EnemySummonTable
		{ 
			get
			{
				int value_as_int = (int)((m_AuxillaryParameters2 & 0x00FF) >> 0);
				return (EnemySummonTableEnum)value_as_int;
			}

			set
			{
				int value_as_int = (int)value;
				m_AuxillaryParameters2 = (short)(m_AuxillaryParameters2 & ~0x00FF | (value_as_int << 0 & 0x00FF));
				OnPropertyChanged("EnemySummonTable");
			}
		}

		// Constructor
		public wz(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ygcwp : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ygcwp", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000000F) >> 0);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000000F | (value_as_int << 0 & 0x0000000F));
				OnPropertyChanged("Unknown_1");
			}
		}

		// Constructor
		public ygcwp(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class ykgr : Actor
	{
		// Auto-Generated Properties from Templates
		[WProperty("ykgr", "Unknown_1", true, "", SourceScene.Room)]
		public int Unknown_1
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x0000FF00) >> 8);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x0000FF00 | (value_as_int << 8 & 0x0000FF00));
				OnPropertyChanged("Unknown_1");
			}
		}

		[WProperty("ykgr", "Unknown_2", true, "", SourceScene.Room)]
		public int Unknown_2
		{ 
			get
			{
				int value_as_int = (int)((m_Parameters & 0x00F00000) >> 20);
				return value_as_int;
			}

			set
			{
				int value_as_int = value;
				m_Parameters = (int)(m_Parameters & ~0x00F00000 | (value_as_int << 20 & 0x00F00000));
				OnPropertyChanged("Unknown_2");
			}
		}

		// Constructor
		public ykgr(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}

	// AUTO-GENERATED, MODIFICATIONS TO THIS FILE WILL BE LOST
	public partial class yougan : Actor
	{
		// Auto-Generated Properties from Templates
		// Constructor
		public yougan(FourCC fourCC, WWorld world) : base(fourCC, world)
		{
			
		}
	}


} // namespace WindEditor

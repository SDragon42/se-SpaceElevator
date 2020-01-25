// <mdk sortorder="900" />
using Sandbox.Game.EntityComponents;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System;
using VRage.Collections;
using VRage.Game.Components;
using VRage.Game.GUI.TextPanel;
using VRage.Game.ModAPI.Ingame.Utilities;
using VRage.Game.ModAPI.Ingame;
using VRage.Game.ObjectBuilders.Definitions;
using VRage.Game;
using VRage;
using VRageMath;

namespace IngameScript {
    partial class Program {
        public partial class Collect {

            public static bool IsTagged(IMyTerminalBlock b, string tag) => b.CustomName.IndexOf(tag, StringComparison.OrdinalIgnoreCase) >= 0;

            public static bool IsDoor(IMyTerminalBlock b) => b is IMyDoor;
            
            public static bool IsGasTank(IMyTerminalBlock b) => b is IMyGasTank;
            public static bool IsOxygenTank(IMyTerminalBlock b) => IsGasTank(b) && !b.BlockDefinition.SubtypeId.Contains("Hydro");
            public static bool IsHydrogenTank(IMyTerminalBlock b) => IsGasTank(b) && b.BlockDefinition.SubtypeId.Contains("Hydro");

            public static bool IsLandingGearLocked(IMyTerminalBlock b) => IsLandingGearLocked(b as IMyLandingGear);
            public static bool IsLandingGearLocked(IMyLandingGear b) => b.LockMode == LandingGearMode.Locked;

            public static bool IsTextPanel(IMyTerminalBlock b) => b is IMyTextPanel;
            public static bool IsAngledCornerLcd(IMyTerminalBlock b) => IsTextPanel(b) && (IsSmAngledCornerLcd(b) || IsLgAngledCornerLcd(b));
            public static bool IsSmAngledCornerLcd(IMyTerminalBlock b) => IsTextPanel(b) && (b.BlockDefinition.SubtypeId == SubTypeIDs.CornerLcdPanel1SM || b.BlockDefinition.SubtypeId == SubTypeIDs.CornerLcdPanel2SM);
            public static bool IsLgAngledCornerLcd(IMyTerminalBlock b) => IsTextPanel(b) && (b.BlockDefinition.SubtypeId == SubTypeIDs.CornerLcdPanel1LG || b.BlockDefinition.SubtypeId == SubTypeIDs.CornerLcdPanel2LG);
            public static bool IsFlatCornerLcd(IMyTerminalBlock b) => IsTextPanel(b) && (IsSmFlatCornerLcd(b) || IsLgFlatCornerLcd(b));
            public static bool IsSmFlatCornerLcd(IMyTerminalBlock b) => IsTextPanel(b) && (b.BlockDefinition.SubtypeId == SubTypeIDs.FlatCornerLcdPanel1SM || b.BlockDefinition.SubtypeId == SubTypeIDs.FlatCornerLcdPanel2SM);
            public static bool IsLgFlatCornerLcd(IMyTerminalBlock b) => IsTextPanel(b) && (b.BlockDefinition.SubtypeId == SubTypeIDs.FlatCornerLcdPanel1LG || b.BlockDefinition.SubtypeId == SubTypeIDs.FlatCornerLcdPanel2LG);
            public static bool IsCornerLcd(IMyTerminalBlock b) => IsTextPanel(b) && (IsAngledCornerLcd(b) || IsFlatCornerLcd(b));
            
            public static bool IsCommRadioAntenna(IMyTerminalBlock b) => (b is IMyRadioAntenna && IsCommRadioAntenna((IMyRadioAntenna)b));
            public static bool IsCommRadioAntenna(IMyRadioAntenna b) => (b.Enabled && b.EnableBroadcasting);
        }
    }
}

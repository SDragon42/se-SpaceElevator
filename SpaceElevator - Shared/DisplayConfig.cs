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
        class DisplayConfig {
            private DisplayConfig() { }

            public float FontSize { get; private set; }
            public float TextPadding { get; private set; }
            public TextAlignment Alignment { get; private set; }


            private static readonly DisplayConfig CARRIAGE_GFX = new DisplayConfig() { FontSize = 0.95f, TextPadding = 2f };
            private static readonly DisplayConfig CARRIAGE_GFX_60 = new DisplayConfig() { FontSize = 0.56f, TextPadding = 2f };

            public static DisplayConfig GetCarriageGfx(IMyTextPanel display) => (display.BlockDefinition.SubtypeId == "LargeTextPanel") ? CARRIAGE_GFX_60 : CARRIAGE_GFX;

            public static readonly DisplayConfig DESTINATION = new DisplayConfig() { FontSize = 6.5f, TextPadding = 15.0f, Alignment = TextAlignment.CENTER };
            public static readonly DisplayConfig SPEED = new DisplayConfig() { FontSize = 4.6f };
            public static readonly DisplayConfig FUEL = new DisplayConfig() { FontSize = 4.6f };
            public static readonly DisplayConfig CARGO = new DisplayConfig() { FontSize = 4.6f };
            public static readonly DisplayConfig LOG = new DisplayConfig() { FontSize = 0.5f }; // TODO: verify this is correct
        }
    }
}
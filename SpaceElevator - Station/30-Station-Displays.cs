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

        //-------------------------------------------------------------------------------
        //  Displays
        //-------------------------------------------------------------------------------
        void DisplayProcessing(string payload) {
            var msg = UpdateAllDisplaysMessage.CreateFromPayload(payload);

            _displaysAllCarriages.ForEach(d => Displays.Write2MonospaceDisplay(d, msg.AllCarriages, DisplayConfig.GetCarriageGfx(d)));
            _displaysAllCarriagesWide.ForEach(d => Displays.Write2MonospaceDisplay(d, msg.AllCarriagesWide, DisplayConfig.GetCarriageGfx(d)));
            _displaysAllPassengerCarriages.ForEach(d => Displays.Write2MonospaceDisplay(d, msg.AllPassCarriages, DisplayConfig.GetCarriageGfx(d)));
            _displaysAllPassengerCarriagesWide.ForEach(d => Displays.Write2MonospaceDisplay(d, msg.AllPassCarriagesWide, DisplayConfig.GetCarriageGfx(d)));

            foreach (var d in _displaysSingleCarriages) {
                if (IsGateA1(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageA1, DisplayConfig.GetCarriageGfx(d));
                } else if (IsGateA2(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageA2, DisplayConfig.GetCarriageGfx(d));
                } else if (IsGateB1(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageB1, DisplayConfig.GetCarriageGfx(d));
                } else if (IsGateB2(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageB2, DisplayConfig.GetCarriageGfx(d));
                } else if (IsGateMaint(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageMaint, DisplayConfig.GetCarriageGfx(d));
                }
            }

            foreach (var d in _displaysSingleCarriagesDetailed) {
                if (IsGateA1(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageA1Details, DisplayConfig.GetCarriageGfx(d));
                } else if (IsGateA2(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageA2Details, DisplayConfig.GetCarriageGfx(d));
                } else if (IsGateB1(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageB1Details, DisplayConfig.GetCarriageGfx(d));
                } else if (IsGateB2(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageB2Details, DisplayConfig.GetCarriageGfx(d));
                } else if (IsGateMaint(d)) {
                    Displays.Write2MonospaceDisplay(d, msg.CarriageMaintDetails, DisplayConfig.GetCarriageGfx(d));
                }
            }
        }

    }
}

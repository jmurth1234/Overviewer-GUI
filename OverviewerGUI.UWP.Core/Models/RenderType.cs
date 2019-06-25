using System;
using System.Collections.Generic;
using System.Text;

namespace OverviewerGUI.Core.Models
{
    public class RenderType
    {
        public string Mode { get; set; }
        public string Type { get; set; }

        public static RenderType Normal = new RenderType
        {
            Mode = "normal",
            Type = "Normal"
        };

        public static RenderType Lighting = new RenderType
        {
            Mode = "lighting",
            Type = "Lighting"
        };

        public static RenderType SmoothLighting = new RenderType
        {
            Mode = "smooth_lighting",
            Type = "Smooth lighting"
        };

        public static RenderType Night = new RenderType
        {
            Mode = "night",
            Type = "Night"
        };

        public static RenderType NightSmooth = new RenderType
        {
            Mode = "smooth_night",
            Type = "Smooth Night"
        };

        public static RenderType Cave = new RenderType
        {
            Mode = "cave",
            Type = "Cave"
        };

    }
}

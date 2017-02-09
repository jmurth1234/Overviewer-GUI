using OverviewerGUI.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace OverviewerGUI
{
    class OverviewerConfigGenerator
    {
        private string HeaderTemplate = "worlds[\"{0}\"] = \"{1}\"";

        private string RenderModeTemplate = String.Join(
            Environment.NewLine,
            "renders[\"{0}\"] = {{",
            "    \"world\": \"{1}\",",
            "    \"rendermode\": \"{0}\",",
            "    \"title\": \"{2} render of {1}\",",
            "}}");

         
        private string OutputDirTemplate = "outputdir = \"{0}\"";

        public string WorldName { get; set; }
        public string WorldPath { get; set; }
        public List<Render> RenderModes { get; set; }
        public string OutputDir { get; set; }

        public String generateConfig()
        {
            var config = "";

            config += Resources.Observer + Environment.NewLine;
            config += String.Format(HeaderTemplate, WorldName, WorldPath) + Environment.NewLine;

            foreach (Render mode in RenderModes)
            {
                config += String.Format(RenderModeTemplate, mode.Mode, WorldName, mode.Type) + Environment.NewLine;
            }

            config += String.Format(OutputDirTemplate, OutputDir) + Environment.NewLine;

            config = config.Replace("\\", "\\\\");

            return config;
        }
    }

    public class Render
    {
        public string Mode { get; set; }
        public string Type { get; set; }

        public static Render Normal = new Render
        {
            Mode = "normal",
            Type = "Normal"
        };

        public static Render Lighting = new Render
        {
            Mode = "lighting",
            Type = "Lighting"
        };

        public static Render SmoothLighting = new Render
        {
            Mode = "smooth_lighting",
            Type = "Smooth lighting"
        };

        public static Render Night = new Render
        {
            Mode = "night",
            Type = "Night"
        };

        public static Render NightSmooth = new Render
        {
            Mode = "smooth_night",
            Type = "Smooth Night"
        };

        public static Render Cave = new Render
        {
            Mode = "cave",
            Type = "Cave"
        };
    }
}

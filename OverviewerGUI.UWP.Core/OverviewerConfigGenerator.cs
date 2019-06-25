using OverviewerGUI.Core.Models;
using OverviewerGUI.UWP.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;

namespace OverviewerGUI.Core
{
    public class OverviewerConfigGenerator
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

        public string OutputDir { get; set; }

        public List<World> Worlds { get; set; }

        public String generateConfig()
        {
            var config = "";

            config += Resources.Observer + Environment.NewLine;

            foreach (var world in Worlds)
            {
                config += String.Format(HeaderTemplate, world.WorldName, world.WorldPath) + Environment.NewLine;

                foreach (RenderType mode in world.RenderModes)
                {
                    config += String.Format(RenderModeTemplate, mode.Mode, world.WorldName, mode.Type) + Environment.NewLine;
                }
            }

            config += String.Format(OutputDirTemplate, OutputDir) + Environment.NewLine;

            config = config.Replace("\\", "\\\\");

            return config;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OverviewerGUI.Core.Models
{
    public class World
    {
        public string WorldName { get; set; }
        public string WorldPath { get; set; }
        public List<RenderType> RenderModes { get; set; }
    }
}

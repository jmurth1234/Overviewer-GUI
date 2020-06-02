using GalaSoft.MvvmLight;
using OverviewerGUI.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewerGUI.WinUI.ViewModels
{
    public class SimpleViewModel : ViewModelBase
    {
        public ObservableCollection<World> Worlds { get; } = new ObservableCollection<World>();

        public SimpleViewModel()
        {
            CreateWorld();
        }

        public void CreateWorld()
        {
            Worlds.Add(new World() { WorldName = "<new world>" });
        }
    }
}

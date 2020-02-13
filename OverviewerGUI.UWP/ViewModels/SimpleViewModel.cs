using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using OverviewerGUI.Core.Models;

namespace OverviewerGUI.UWP.ViewModels
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

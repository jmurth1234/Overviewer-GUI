using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace OverviewerGUI.Core.Models
{
    public class World : INotifyPropertyChanged
    {
        private string _worldName;
        private string _worldPath;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string WorldName
        {
            get { return this._worldName; }
            set
            {
                this._worldName = value;
                this.OnPropertyChanged();
            }
        }

        public string WorldPath
        {
            get { return this._worldPath; }
            set
            {
                this._worldPath = value;
                this.OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<RenderType> RenderModes { get; set; }

        public List<RenderType> PossibleModes { get; set; } = new List<RenderType>
        {
            RenderType.Normal,
            RenderType.Lighting,
            RenderType.SmoothLighting,
            RenderType.Night,
            RenderType.NightSmooth,
            RenderType.Cave,
        };
    }
}

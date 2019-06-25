using System;

using OverviewerGUI.UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace OverviewerGUI.UWP.Views
{
    public sealed partial class SimplePage : Page
    {
        private SimpleViewModel ViewModel
        {
            get { return ViewModelLocator.Current.SimpleViewModel; }
        }

        public SimplePage()
        {
            InitializeComponent();
        }
    }
}

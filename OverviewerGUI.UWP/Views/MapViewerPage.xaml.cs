using System;

using OverviewerGUI.UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace OverviewerGUI.UWP.Views
{
    public sealed partial class MapViewerPage : Page
    {
        private MapViewerViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MapViewerViewModel; }
        }

        public MapViewerPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}

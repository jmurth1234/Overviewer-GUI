using System;

using OverviewerGUI.UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace OverviewerGUI.UWP.Views
{
    public sealed partial class AdvancedPage : Page
    {
        private AdvancedViewModel ViewModel
        {
            get { return ViewModelLocator.Current.AdvancedViewModel; }
        }

        public AdvancedPage()
        {
            InitializeComponent();
        }
    }
}

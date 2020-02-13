using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace OverviewerGUI.UWP.Views
{
    public sealed partial class FileSelector : UserControl
    {
        public FileSelector()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register
        (
            "Title", typeof(String), typeof(FileSelector), new PropertyMetadata(default(String))
        );

        public String Title
        {
            get { return (String)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty FilePathProperty = DependencyProperty.Register
        (
            "FilePath", typeof(String), typeof(FileSelector), new PropertyMetadata(default(String))
        );

        public String FilePath
        {
            get { return (String)GetValue(FilePathProperty); }
            set { SetValue(FilePathProperty, value); }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var folderPicker = new Windows.Storage.Pickers.FolderPicker();
            folderPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.Desktop;
            folderPicker.FileTypeFilter.Add("*");

            Windows.Storage.StorageFolder folder = await folderPicker.PickSingleFolderAsync();
            if (folder != null)
            {
                // Application now has read/write access to all contents in the picked folder
                // (including other sub-folder contents)
                Windows.Storage.AccessCache.StorageApplicationPermissions.
                FutureAccessList.AddOrReplace("PickedFolderToken", folder);
                FilePath = folder.Path;
            }
            else
            {
                FilePath = "";
            }
        }
    }
}

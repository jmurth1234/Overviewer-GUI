using System;

using GalaSoft.MvvmLight.Ioc;

using OverviewerGUI.UWP.Services;
using OverviewerGUI.UWP.Views;

namespace OverviewerGUI.UWP.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        private static ViewModelLocator _current;

        public static ViewModelLocator Current => _current ?? (_current = new ViewModelLocator());

        private ViewModelLocator()
        {
            if (SimpleIoc.Default.IsRegistered<NavigationServiceEx>())
            {
                return;
            }

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<SimpleViewModel, SimplePage>();
            Register<AdvancedViewModel, AdvancedPage>();
            Register<MapViewerViewModel, MapViewerPage>();
            Register<ShareTargetViewModel, ShareTargetPage>();
        }

        public ShareTargetViewModel ShareTargetViewModel => SimpleIoc.Default.GetInstance<ShareTargetViewModel>();

        public MapViewerViewModel MapViewerViewModel => SimpleIoc.Default.GetInstance<MapViewerViewModel>();

        public AdvancedViewModel AdvancedViewModel => SimpleIoc.Default.GetInstance<AdvancedViewModel>();

        public SimpleViewModel SimpleViewModel => SimpleIoc.Default.GetInstance<SimpleViewModel>();

        public ShellViewModel ShellViewModel => SimpleIoc.Default.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => SimpleIoc.Default.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}

using GalaSoft.MvvmLight.Ioc;
using OverviewerGUI.WinUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewerGUI.WinUI.ViewModels
{
    class Locator
    {
        private static Locator _current;

        public static Locator Current => _current ?? (_current = new Locator());

        private Locator()
        {
            if (SimpleIoc.Default.IsRegistered<NavigationService>())
            {
                return;
            }

            SimpleIoc.Default.Register(() => new NavigationService());

            SimpleIoc.Default.Register<MainWindowViewModel>();
        }

        public NavigationService NavigationService => SimpleIoc.Default.GetInstance<NavigationService>();

        public MainWindowViewModel MainWindowViewModel => SimpleIoc.Default.GetInstance<MainWindowViewModel>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();
            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}

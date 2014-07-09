using System;
using System.Windows;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using WordSplitter.GUI.View;
using WordSplitter.GUI.ViewModel;

namespace WordSplitter.GUI
{
    public class GuiBootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }


        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.DataContext = Container.Resolve<ShellViewModel>();
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();


            // App
            Container.RegisterType<ShellViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<ResultsViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IInstanceCounter, InstanceCounter>(new ContainerControlledLifetimeManager());
        }
    }
}

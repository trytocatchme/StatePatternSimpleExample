using System;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace StatePatternSimpleExample
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
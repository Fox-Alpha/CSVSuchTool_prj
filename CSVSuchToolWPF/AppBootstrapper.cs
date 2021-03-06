﻿using System.Windows;
using System.Windows.Threading;
using CSVSuchToolWPF.ViewModels;
using Stylet;
using StyletIoC;
//using CSVSuchToolWPF.Services;

namespace CSVSuchToolWPF
{
    public class Bootstrapper : Bootstrapper<MainWindowViewModel>
    {
        protected override void OnStart()
        {
            // This is called just after the application is started, but before the IoC container is set up.
            // Set up things like logging, this.Assemblies, etc
        }
        
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            // Bind your own types. Concrete types are automatically self-bound.
            builder.Bind<Models.SettingsModel> ().ToSelf ().InSingletonScope ();
        }

        protected override void Configure()
        {
            // This is called after Stylet has created the IoC container, so this.Container exists, but before the
            // Root ViewModel is launched.
            // Configure your services, etc, in here
            var settings = Container.Get<Models.SettingsModel> ();
            if(!settings.LoadSettings ())
            {
                settings.SaveSettings ();
            }
        }

        protected override void OnLaunch()
        {
            // This is called just after the root ViewModel has been launched
            // Something like a version check that displays a dialog might be launched from here
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // Called on Application.Exit
            var settings = Container.Get<Models.SettingsModel> ();
            settings.SaveSettings ();
        }

        protected override void OnUnhandledException(DispatcherUnhandledExceptionEventArgs e)
        {
            // Called on Application.DispatcherUnhandledException
            Container.Get<IWindowManager> ().ShowMessageBox ($"An unhandled Exception occurred:\n{e.Exception.ToString ()}");
        }
    }
}

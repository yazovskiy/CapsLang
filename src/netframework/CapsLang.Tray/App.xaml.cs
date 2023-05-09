using CapsLang.Tray.Resources;
using System;
using System.Windows;
using System.Windows.Forms;

namespace CapsLang.Tray
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private MainWindow _window = new MainWindow();

        protected override void OnStartup(StartupEventArgs e)
        {
            CreateNotifyIcon();
            base.OnStartup(e);
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            _window.Show();
            _window.Activate();
        }

        private void CreateNotifyIcon()
        {
            NotifyIcon icon = new NotifyIcon();
            icon.Icon = CapsLangResources.capslang_icon_transparent;
            icon.Visible = true;
            icon.Text = "CapsLang";
            icon.Click += Icon_Click;
            icon.ContextMenu = CreateContextMenu();
        }

        private ContextMenu CreateContextMenu()
        {
            ContextMenu menu = new ContextMenu();
            MenuItem exitItem = new MenuItem();
            exitItem.Text = "Exit";
            exitItem.Click += ExitItem_Click;
            menu.MenuItems.Add(exitItem);
            return menu;
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            this.Shutdown();
        }
    }
}

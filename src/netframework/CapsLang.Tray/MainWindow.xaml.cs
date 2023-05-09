using System;
using System.Windows;

namespace CapsLang.Tray
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LangSwitcher.LangSwitcher.Run();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            LangSwitcher.LangSwitcher.Release();
        }
    }
}

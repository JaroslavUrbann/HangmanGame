using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace hangman
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            var settings = Application.Current.FindResource("Settings");
            if (settings is hangman.Properties.Settings)
            {
                (settings as hangman.Properties.Settings).Save();
            }
        }
    }
}

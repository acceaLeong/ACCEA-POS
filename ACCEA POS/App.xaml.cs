using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;

namespace ACCEA_POS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ChangeCulture("en");

            var _wndw = new MainWindow();
            _wndw.Show();
        }

        public static void ChangeCulture(string code)
        {
            CultureInfo _info = CultureInfo.CreateSpecificCulture(code);

            Thread.CurrentThread.CurrentCulture = _info;
            Thread.CurrentThread.CurrentUICulture = _info;
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using ACCEA_POS.ViewModels;

namespace ACCEA_POS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //DataContext = new MainVM();

            InitializeComponent();

            //cmbxLang.Items.Add("en");
            //cmbxLang.Items.Add("ja");
        }            

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    App.ChangeCulture("ja");
        //}

        private void cmbxLang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //App.ChangeCulture(cmbxLang.SelectedValue as string);
        }
    }

    //public partial class MainViewModel : ObservableObject
    //{
    //    //public MainViewModel()
    //    //{

    //    //}

    //    //[ObservableProperty]
    //    //string cmbxValue;

    //    //[ICommand]
    //    [RelayCommand]
    //    void CmbxLang()
    //    {
    //        MessageBox.Show("abc");
    //    }
    //}
}
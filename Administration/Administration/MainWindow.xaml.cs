using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Administration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;        
        }

        private void pet_administration_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new pet_administration(){ WindowStartupLocation = WindowStartupLocation.CenterScreen}.ShowDialog();
            Show();  
        }

        private void user_administration_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new user_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
            Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}

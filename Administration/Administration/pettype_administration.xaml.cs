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
using System.Windows.Shapes;

namespace Administration
{
    /// <summary>
    /// Interaction logic for pettype_administration.xaml
    /// </summary>
    public partial class pettype_administration : Window
    {
        public pettype_administration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja ezt a típust?", "Törlés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // selecteduser delete  
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (typescb.Text.ToLower() == "típus hozzáadása")
            {
                MessageBox.Show("új állat neve");
            }
            else
            {
                MessageBox.Show("nem új állatot akar felvenni");
            }
        }
    }
}

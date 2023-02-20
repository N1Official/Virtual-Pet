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
    /// Interaction logic for user_administration.xaml
    /// </summary>
    public partial class user_administration : Window
    {
        public user_administration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            User changedUser = new User();
            changedUser.Id = int.Parse(idcb.Text); 
            changedUser.Pets_id = pets_idtb.Text;
            changedUser.Email = emailtb.Text;
            changedUser.Password = pwtb.Password;
            changedUser.FirstName = firstnametb.Text;
            changedUser.LastName = lastnametb.Text;
            changedUser.Gender = gendercb.Text;
            changedUser.Birthday = DateTime.Parse(birthdaydp.Text);
            changedUser.Phone = phonetb.Text;
            changedUser.Address = addresstb.Text;
            changedUser.City = addresstb.Text;
            changedUser.State = statetb.Text;
            changedUser.Zipcode = int.Parse(zipcodetb.Text);
            changedUser.Country = countrytb.Text;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja ezt a felhasználót?", "Törlés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // selecteduser delete  
            }
        }

        private void newuser_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new newuser_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
        }
    }
}

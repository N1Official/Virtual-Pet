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
            changedUser.id = int.Parse(idcb.Text); 
            changedUser.pets_id = pets_idtb.Text;
            changedUser.email = emailtb.Text;
            changedUser.password = pwtb.Password;
            changedUser.firstName = firstnametb.Text;
            changedUser.lastName = lastnametb.Text;
            changedUser.gender = gendercb.Text;
            changedUser.birthday = DateTime.Parse(birthdaydp.Text);
            changedUser.phone = phonetb.Text;
            changedUser.address = addresstb.Text;
            changedUser.city = addresstb.Text;
            changedUser.state = statetb.Text;
            changedUser.zipcode = int.Parse(zipcodetb.Text);
            changedUser.country = countrytb.Text;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja ezt a felhasználót?", "Törlés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                int ind = int.Parse(idcb.Text);
                //Users.RemoveAt(ind-1);
                idcb.Items.Remove(ind);
                pets_idtb.Text = null;
                usernametb.Text = null;
                pwtb.Password = null;
                emailtb.Text = null;
                phonetb.Text = null;
                firstnametb.Text = null;
                lastnametb.Text = null;
                birthdaydp.Text = null;
                gendercb.Text = null;
                countrytb.Text = null;
                statetb.Text = null;
                zipcodetb.Text = null;
                citytb.Text = null;
                addresstb.Text = null;
            }
        }

        private void newuser_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new newuser_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
        }

        private void idcb_DropDownClosed(object sender, EventArgs e)
        {
            /*if (idcb.Text != "")
            {
                int index = int.Parse(idcb.Text)-1;
                pets_idtb.Text = Users[index].Pets_id;
                usernametb.Text = Users[index].Username;
                pwtb.Password = Users[index].Password;
                emailtb.Text = Users[index].Email;
                phonetb.Text = Users[index].Phone;
                firstnametb.Text = Users[index].FirstName;
                lastnametb.Text = Users[index].LastName;
                birthdaydp.Text = Users[index].Birthday.ToString();
                gendercb.Text = Users[index].Gender;
                countrytb.Text = Users[index].Country;
                statetb.Text = Users[index].State;
                zipcodetb.Text = Users[index].Zipcode.ToString();
                citytb.Text = Users[index].City;
                addresstb.Text = Users[index].Address;
            }*/
        }
    }
}

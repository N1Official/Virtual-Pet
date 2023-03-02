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
        static RestApiHandler restapihandler = new RestApiHandler("http://localhost:8881");
        static User[] Users = restapihandler.GetUsers("api/users");
        public user_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Users.Length; i++)
            {
                idcb.Items.Add(Users[i].id);
            }
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
            changedUser.birthday = DateTime.Parse(birthdaydp.Text).Date;
            changedUser.phone = phonetb.Text;
            changedUser.address = addresstb.Text;
            changedUser.city = addresstb.Text;
            changedUser.state = statetb.Text;
            changedUser.zipcode = int.Parse(zipcodetb.Text);
            changedUser.country = countrytb.Text;
            restapihandler.UpdateUserAsync(changedUser);
            MessageBox.Show("Változások elmentve!");
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja ezt a felhasználót?", "Törlés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                int ind = int.Parse(idcb.Text);
                restapihandler.DeleteUserAsync(ind.ToString());
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
            if (idcb.Text != "")
            {
                int index = int.Parse(idcb.Text);
                for (int i = 0; i < Users.Length; i++)
                {
                    if (Users[i].id == index)
                    {
                        pets_idtb.Text = Users[i].pets_id;
                        usernametb.Text = Users[i].username;
                        pwtb.Password = Users[i].password;
                        emailtb.Text = Users[i].email;
                        phonetb.Text = Users[i].phone;
                        firstnametb.Text = Users[i].firstName;
                        lastnametb.Text = Users[i].lastName;
                        birthdaydp.Text = Users[i].birthday.ToString();
                        gendercb.Text = Users[i].gender;
                        countrytb.Text = Users[i].country;
                        statetb.Text = Users[i].state;
                        zipcodetb.Text = Users[i].zipcode.ToString();
                        citytb.Text = Users[i].city;
                        addresstb.Text = Users[i].address;
                    }
                }

            }
        }
    }
}

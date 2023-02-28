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
    /// Interaction logic for newuser_administration.xaml
    /// </summary>
    public partial class newuser_administration : Window
    {
        List<string> Genders = new List<string>() {"Férfi","Nő"};
        public newuser_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Genders.Count; i++)
            {
                gendercb.Items.Add(Genders[i]);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User();
            newUser.id = int.Parse(idcb.Text);// check is required!!
            newUser.pets_id = pets_idtb.Text;
            newUser.email = emailtb.Text;
            newUser.password = pwtb.Password;
            newUser.firstName = firstnametb.Text;
            newUser.lastName = lastnametb.Text;
            newUser.gender = gendercb.Text;
            newUser.birthday = DateTime.Parse(birthdaydp.Text);
            newUser.phone = phonetb.Text;
            newUser.address = addresstb.Text;
            newUser.city = addresstb.Text;
            newUser.state = statetb.Text;
            newUser.zipcode = int.Parse(zipcodetb.Text);
            newUser.country = countrytb.Text;
            MessageBox.Show("Új felhasználó felvéve: \n\tNeve:\t" + newUser.firstName + " " + newUser.lastName + "\n\tE-mail címe:\t" + newUser.email + "\n\tTelefonszáma:\t" + newUser.phone + "\n\tNeme:\t" + newUser.gender + "\n\tLakcíme:\t" + newUser.zipcode +" "+ newUser.state +"\n\t" +newUser.address + "\n\t" + newUser.country);
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
}

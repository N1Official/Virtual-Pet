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
            newUser.Id = int.Parse(idcb.Text);// check is required!!
            newUser.Pets_id = pets_idtb.Text;
            newUser.Email = emailtb.Text;
            newUser.Password = pwtb.Password;
            newUser.FirstName = firstnametb.Text;
            newUser.LastName = lastnametb.Text;
            newUser.Gender = gendercb.Text;
            newUser.Birthday = DateTime.Parse(birthdaydp.Text);
            newUser.Phone = phonetb.Text;
            newUser.Address = addresstb.Text;
            newUser.City = addresstb.Text;
            newUser.State = statetb.Text;
            newUser.Zipcode = int.Parse(zipcodetb.Text);
            newUser.Country = countrytb.Text;
            MessageBox.Show("Új felhasználó felvéve: \n\tNeve:\t" + newUser.FirstName + " " + newUser.LastName + "\n\tE-mail címe:\t" + newUser.Email + "\n\tTelefonszáma:\t" + newUser.Phone + "\n\tNeme:\t" + newUser.Gender + "\n\tLakcíme:\t" + newUser.Zipcode +" "+ newUser.State +"\n\t" +newUser.Address + "\n\t" + newUser.Country);
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

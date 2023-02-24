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
        List<User> Users = new List<User>() 
        { 
            new User(){Id=1,Username="N1off",Pets_id="2",Email="asd@gmail.com",Password="asd",FirstName="laci",LastName="maki",Gender="Férfi",Birthday=DateTime.Today,Phone="+3604204",Address="kisasdasd",City="bp",State="pest",Zipcode=2211,Country="HU",},
            new User(){Id=2,Username="asdasdsadsadasd",Pets_id="5",Email="asd@gmffffffail.com",Password="asd",FirstName="laci",LastName="maki",Gender="Férfi",Birthday=DateTime.Today,Phone="+360575874204",Address="kisasdasd",City="bp",State="pest",Zipcode=2211,Country="HU"},
            new User(){Id=3,Username="N1ozukluklhkjff",Pets_id="10",Email="asd@gmakuizkil.com",Password="asd",FirstName="lrrraci",LastName="maki",Gender="Férfi",Birthday=DateTime.Today,Phone="+36044424204",Address="kisasdasd",City="bp",State="pest",Zipcode=2211,Country="HU"}
        };
        List<string> Genders = new List<string>() { "Férfi", "Nő" };
        public user_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Users.Count; i++)
            {
                idcb.Items.Add(Users[i].Id);
            }
            for (int i = 0; i < Genders.Count; i++)
            {
                gendercb.Items.Add(Genders[i]);
            }
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
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Id == changedUser.Id)
                {
                    Users[i] = changedUser;
                }
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja ezt a felhasználót?", "Törlés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                int ind = int.Parse(idcb.Text);
                Users.RemoveAt(ind-1);
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
            }
        }
    }
}

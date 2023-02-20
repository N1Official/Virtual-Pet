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
        public newuser_administration()
        {
            InitializeComponent();
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
        }
    }
}

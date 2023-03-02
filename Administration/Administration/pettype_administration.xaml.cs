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
        static RestApiHandler restapihandler = new RestApiHandler("http://localhost:8881");
        static PetType[] Types = restapihandler.GetPetTypes("api/pettype");
        public pettype_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Types.Length; i++)
            {
                typescb.Items.Add(Types[i].pettype);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja ezt a típust?", "Törlés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                string deltyp = typescb.Text;
                restapihandler.DeletePetTypeAsync(deltyp);
                typescb.Items.Remove(deltyp);
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (typescb.Text == "ÚJ TÍPUS" && newtypetb.Text != "")
            {
                bool checker = false;
                for (int i = 0; i < Types.Length; i++)
                {
                    if (Types[i].pettype.ToLower() == newtypetb.Text.ToLower())
                    {
                        checker = true;
                        break;
                    }
                }
                if (checker)
                {
                    MessageBox.Show("Ez a típus már létezik!");
                }
                else
                {
                    PetType newtype = new PetType();
                    newtype.pettype = newtypetb.Text;
                    restapihandler.CreatePetType(newtype);
                    typescb.Items.Add(newtypetb.Text);
                    MessageBox.Show("Új típus hozzáadva!");
                }
                
            }
        }
    }
}

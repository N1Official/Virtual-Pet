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
        public List<string> Types = new List<string>
        {
            "Tiger",
            "Panther",
            "Lion",
            "Snake",
            "Dog",
            "Cat",
            "Hamster"
        };
        public pettype_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Types.Count; i++)
            {
                typescb.Items.Add(Types[i]);
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
                string ind = typescb.Text;
                for (int i = 0; i < Types.Count; i++)
                {
                    if (Types[i].ToLower() == ind.ToLower())
                    {
                        Types.RemoveAt(i);
                    }
                }
                typescb.Items.Remove(ind);
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (typescb.Text == "ÚJ TÍPUS" && newtypetb.Text != "")
            {
                Types.Add(newtypetb.Text);
                typescb.Items.Add(newtypetb.Text);
            }
        }
    }
}

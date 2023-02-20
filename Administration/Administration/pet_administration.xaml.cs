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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Administration
{
    /// <summary>
    /// Interaction logic for pet_administration.xaml
    /// </summary>
    public partial class pet_administration : Window
    {
        public bool isclosed { get; private set; } = false;
        public pet_administration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            isclosed = true;
            Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Pet changedPet = new Pet();
            changedPet.Id = int.Parse(idcb.Text);
            changedPet.Name = nametb.Text;
            changedPet.Type = typecb.Text;
            changedPet.Hunger = hungerslider.Value;
            changedPet.Thirst = thirstslider.Value;
            changedPet.Mood = moodcb.Text;
            changedPet.Speed = speedslider.Value;
            changedPet.Health = healthslider.Value;
            changedPet.Skill = skillslider.Value;
            changedPet.Age = double.Parse(agetb.Text);
            changedPet.Age_group = agegroupcb.Text;
        }

        private void newpet_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new newpet_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
        }

        private void mood_Click(object sender, RoutedEventArgs e)
        {
            new petmood_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
        }

        private void type_Click(object sender, RoutedEventArgs e)
        {
            new pettype_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja ezt a kisállatot?", "Törlés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // selecteduser delete  
            }
        }
    }
}

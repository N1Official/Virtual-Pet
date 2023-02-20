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
        public pet_administration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Pet changedPet = new Pet();
            changedPet.Id = idcb.Text;
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
            Show();
        }
    }
}

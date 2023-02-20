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
    /// Interaction logic for newpet_administration.xaml
    /// </summary>
    public partial class newpet_administration : Window
    {
        public newpet_administration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Pet newPet = new Pet();
            newPet.Id = int.Parse(idtb.Text); // check is required
            newPet.Name = nametb.Text;
            newPet.Type = typecb.Text;
            newPet.Hunger = hungerslider.Value;
            newPet.Thirst = thirstslider.Value;
            newPet.Mood = moodcb.Text;
            newPet.Speed = speedslider.Value;
            newPet.Health = healthslider.Value;
            newPet.Skill = skillslider.Value;
            newPet.Age = double.Parse(agetb.Text);
            newPet.Age_group = agegroupcb.Text;
        }
    }
}

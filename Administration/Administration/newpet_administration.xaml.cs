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
        public List<string> Moods = new List<string>
        {
            "Good",
            "Tired",
            "Mad",
            "Thankful",
            "Touched",
            "Lonely",
            "loved",
            "Stressed",
            "Bored",
        };
        public List<string> Age_Groups = new List<string>
        {
            "Kölyök",
            "Felnőtt",
            "Öreg",
            "Legendary"
        };
        public newpet_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Moods.Count; i++)
            {
                moodcb.Items.Add(Moods[i]);
            }
            for (int i = 0; i < Types.Count; i++)
            {
                typecb.Items.Add(Types[i]);
            }
            for (int i = 0; i < Age_Groups.Count; i++)
            {
                agegroupcb.Items.Add(Age_Groups[i]);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Pet newPet = new Pet();
            newPet.Id = int.Parse(idtb.Text); // check is required
            newPet.User_id = int.Parse(user_idtb.Text);
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
            
            MessageBox.Show("A következő állat felvéve: \n\tNeve:\t" + newPet.Name + "\n\tTípusa:\t" + newPet.Type + "\n\tÉhség szintje:\t" + Math.Round(newPet.Hunger, 0) + "\n\tSzomjúság szintje:\t" + Math.Round(newPet.Thirst, 0) + "\n\tGyorsaság:\t" + Math.Round(newPet.Speed, 0) + "\n\tÉleterő:\t" + Math.Round(newPet.Health, 0) + "\n\tKor:\t" + newPet.Age + "\n\tKorcsoport:\t" + newPet.Age_group + "\n\tÜgyesség:\t" + Math.Round(newPet.Skill, 0) + "\n\tHangulat:\t" + newPet.Mood + "\n\tGazdaAzonosító:\t" + newPet.User_id);
            idtb.Text = null;
            nametb.Text = null;
            typecb.Text = null;
            hungerslider.Value = 0;
            thirstslider.Value = 0;
            moodcb.Text = null;
            speedslider.Value = 0;
            healthslider.Value = 0;
            skillslider.Value = 0;
            agetb.Text = null;
            agegroupcb.Text = null;
            user_idtb.Text = null;
        }
    }
}

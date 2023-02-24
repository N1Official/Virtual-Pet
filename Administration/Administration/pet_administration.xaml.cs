using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        List<Pet> Pets = new List<Pet>()
        {
            new Pet(1,0,"tiger","null",0,0,"null",12,0,0,0,"null"),
            new Pet(2,0,"panther","null",0,0,"null",20,0,0,0,"null"),
            new Pet(3,0,"lion","null",0,0,"null",0,0,30,0,"null"),
            new Pet(4, 0, "snake", "null", 0, 0, "null",50, 0, 0, 0, "null"),
            new Pet(5, 0, "dog", "null", 0, 0, "null", 0, 60, 0, 0, "null"),
            new Pet(6, 0, "cat", "null", 0, 0, "null", 0, 70, 0, 0, "null"),
            new Pet(7, 0, "hamster", "null", 0, 0, "null", 0, 20, 0, 0, "null"),
        };
        public List<string> Age_Groups = new List<string>
        {
            "Kölyök",
            "Felnőtt",
            "Öreg",
            "Legendary"
        };
        public pet_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Pets.Count; i++)
            {
                idcb.Items.Add(Pets[i].Id);
            }
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
            for (int i = 0; i < Pets.Count; i++)
            {
                if (Pets[i].Id == changedPet.Id)
                {
                    Pets[i] = changedPet;
                }
            }
        }

        private void newpet_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new newpet_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
        }

        private void mood_Click(object sender, RoutedEventArgs e)
        {
            new petmood_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
            /*RestApiHandler restapihandler = new RestApiHandler("http://localhost:8881");
            var Pets = restapihandler.GetPets("api/pets");
            MessageBox.Show(Pets.data.Name);*/
        }

        private void type_Click(object sender, RoutedEventArgs e)
        {
            new pettype_administration() { WindowStartupLocation = WindowStartupLocation.CenterScreen }.ShowDialog();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja ezt a kisállatot?", "Törlés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                int ind = int.Parse(idcb.Text);
                Pets.RemoveAt(ind);
                idcb.Items.Remove(ind);
                user_idtb.Text = null;
                nametb.Text = null;
                typecb.SelectedValue = null;
                skillslider.Value = 0;
                thirstslider.Value = 0;
                speedslider.Value = 0;
                hungerslider.Value = 0;
                healthslider.Value = 0;
                agetb.Text = null;
                agegroupcb.SelectedValue = 0;
                moodcb.SelectedValue = 0;
            }
        }

        private void idcb_DropDownClosed(object sender, EventArgs e)
        {  
            if (idcb.Text != "")
            {
                int index = int.Parse(idcb.Text) - 1;
                user_idtb.Text = Pets[index].User_id.ToString();
                nametb.Text = Pets[index].Name;
                typecb.SelectedValue = Pets[index].Type;
                skillslider.Value = Pets[index].Skill;
                thirstslider.Value = Pets[index].Thirst;
                speedslider.Value = Pets[index].Speed;
                hungerslider.Value = Pets[index].Hunger;
                healthslider.Value = Pets[index].Health;
                agetb.Text = Pets[index].Age.ToString();
                agegroupcb.SelectedValue = Pets[index].Age_group;
                moodcb.SelectedValue = Pets[index].Mood;
            }
        }
    }
}

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
        static RestApiHandler restapihandler = new RestApiHandler("http://localhost:8881");
        public pet_administration()
        {
            InitializeComponent();
            var Pets = restapihandler.GetPets("api/pets");
            for (int i = 0; i < Pets.Length; i++)
            {
                idcb.Items.Add((i+1));
            }
            var Moods = restapihandler.GetMoods("api/moods");
            for (int i = 0; i < Moods.Length; i++)
            {
                moodcb.Items.Add(Moods[i].mood);
            }
            var Types = restapihandler.GetPetTypes("api/pettype");
            for (int i = 0; i < Types.Length; i++)
            {
                typecb.Items.Add(Types[i].pettype);
            }
            for (int i = 0; i < Types.Length; i++)
            {
                typecb.Items.Add(Types[i].pettype);
            }
            string[] korcsop = new string[] { "Kölyök", "Felnőtt", "Legendary"};
            for (int i = 0; i < korcsop.Length; i++)
            {
                agegroupcb.Items.Add(korcsop[i]);
            }
        }
        
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

            Pet changedPet = new Pet();
            changedPet.id = int.Parse(idcb.Text);
            changedPet.name = nametb.Text;
            changedPet.type = typecb.Text;
            changedPet.hunger = hungerslider.Value;
            changedPet.thirst = thirstslider.Value;
            changedPet.mood = moodcb.Text;
            changedPet.speed = speedslider.Value;
            changedPet.health = healthslider.Value;
            changedPet.skill = skillslider.Value;
            changedPet.age = double.Parse(agetb.Text);
            changedPet.age_group = agegroupcb.Text;
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
                int ind = int.Parse(idcb.Text);
                //Pets.RemoveAt(ind);
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
            var Pets = restapihandler.GetPets("api/pets");
            if (idcb.Text != "")
            {
                int index = int.Parse(idcb.Text)-1;
                user_idtb.Text = Pets[index].user_id.ToString();
                nametb.Text = Pets[index].name;
                typecb.SelectedValue = Pets[index].type;
                skillslider.Value = Pets[index].skill;
                thirstslider.Value = Pets[index].thirst;
                speedslider.Value = Pets[index].speed;
                hungerslider.Value = Pets[index].hunger;
                healthslider.Value = Pets[index].health;
                agetb.Text = Pets[index].age.ToString();
                agegroupcb.SelectedValue = Pets[index].age_group;
                moodcb.SelectedValue = Pets[index].mood;
            }
        }
    }
}

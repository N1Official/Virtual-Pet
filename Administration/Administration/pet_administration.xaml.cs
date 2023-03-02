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
        static Pet[] Pets = restapihandler.GetPets("api/pets");
        static Mood[] Moods = restapihandler.GetMoods("api/moods");
        static PetType[] Types = restapihandler.GetPetTypes("api/pettype");
        public pet_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Pets.Length; i++)
            {
                idcb.Items.Add(Pets[i].id);
            }
            for (int i = 0; i < Moods.Length; i++)
            {
                moodcb.Items.Add(Moods[i].mood);
            }
            for (int i = 0; i < Types.Length; i++)
            {
                typecb.Items.Add(Types[i].pettype);
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
            changedPet.uid = user_idtb.Text;
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
            restapihandler.UpdatePetAsync(changedPet);
            MessageBox.Show("Változások elmentve!");
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
                restapihandler.DeletePetAsync(ind.ToString());
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
            Pets = restapihandler.GetPets("api/pets");
            if (idcb.Text != "")
            {
                int valasztottid = int.Parse(idcb.Text);
                for (int i = 0; i < Pets.Length; i++)
                {
                    if (Pets[i].id == valasztottid)
                    {
                        user_idtb.Text = Pets[i].uid;
                        nametb.Text = Pets[i].name;
                        typecb.SelectedValue = Pets[i].type;
                        skillslider.Value = Pets[i].skill;
                        thirstslider.Value = Pets[i].thirst;
                        speedslider.Value = Pets[i].speed;
                        hungerslider.Value = Pets[i].hunger;
                        healthslider.Value = Pets[i].health;
                        agetb.Text = Pets[i].age.ToString();
                        agegroupcb.SelectedValue = Pets[i].age_group;
                        moodcb.SelectedValue = Pets[i].mood;
                    }
                } 
            }
        }
        private void typecb_DropDownOpened(object sender, EventArgs e)
        {
            Types = restapihandler.GetPetTypes("api/pettype");
            typecb.Items.Clear();
            for (int i = 0; i < Types.Length; i++)
            {
                typecb.Items.Add(Types[i].pettype);
            }
        }
        private void moodcb_DropDownOpened(object sender, EventArgs e)
        {
            Moods = restapihandler.GetMoods("api/moods");
            moodcb.Items.Clear();
            for (int i = 0; i < Moods.Length; i++)
            {
                moodcb.Items.Add(Moods[i].mood);
            }
        }
    }
}

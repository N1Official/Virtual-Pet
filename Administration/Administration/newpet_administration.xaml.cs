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
        static RestApiHandler restapihandler = new RestApiHandler("http://localhost:8881");
        static Mood[] Moods = restapihandler.GetMoods("api/moods");
        static PetType[] Types = restapihandler.GetPetTypes("api/pettype");
        public newpet_administration()
        {
            InitializeComponent();
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
            bool checker = false;
            Pet[] Pets = restapihandler.GetPets("api/pets");
            for (int i = 0; i < Pets.Length; i++)
            {
                if (Pets[i].id == int.Parse(idtb.Text))
                {
                    checker = true;
                    break;
                }
            }
            if (checker)
            {
                MessageBox.Show("Ezzel az azonosítóval már használnak állatot!");
            }
            else
            {
                Pet newPet = new Pet();
                newPet.id = int.Parse(idtb.Text);
                newPet.user_id = int.Parse(user_idtb.Text);
                newPet.name = nametb.Text;
                newPet.type = typecb.Text;
                newPet.hunger = hungerslider.Value;
                newPet.thirst = thirstslider.Value;
                newPet.mood = moodcb.Text;
                newPet.speed = speedslider.Value;
                newPet.health = healthslider.Value;
                newPet.skill = skillslider.Value;
                newPet.age = double.Parse(agetb.Text);
                newPet.age_group = agegroupcb.Text;
                restapihandler.CreatePet(newPet);
                MessageBox.Show("A következő állat felvéve: \n\tNeve:\t" + newPet.name + "\n\tTípusa:\t" + newPet.type + "\n\tÉhség szintje:\t" + Math.Round(newPet.hunger, 0) + "\n\tSzomjúság szintje:\t" + Math.Round(newPet.thirst, 0) + "\n\tGyorsaság:\t" + Math.Round(newPet.speed, 0) + "\n\tÉleterő:\t" + Math.Round(newPet.health, 0) + "\n\tKor:\t" + newPet.age + "\n\tKorcsoport:\t" + newPet.age_group + "\n\tÜgyesség:\t" + Math.Round(newPet.skill, 0) + "\n\tHangulat:\t" + newPet.mood + "\n\tGazdaAzonosító:\t" + newPet.user_id);
            }
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

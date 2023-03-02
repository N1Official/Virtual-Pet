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
    /// Interaction logic for petmood_administration.xaml
    /// </summary>
    /// 
    public partial class petmood_administration : Window
    {
        static RestApiHandler restapihandler = new RestApiHandler("http://localhost:8881");
        static Mood[] Moods = restapihandler.GetMoods("api/moods");
        public petmood_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Moods.Length; i++)
            {
                moodscb.Items.Add(Moods[i].mood);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni akarja ezt a hangulatot?", "Törlés", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                string delmood = moodscb.Text;
                restapihandler.DeleteMoodAsync(delmood);
                moodscb.Items.Remove(delmood);
            }
        }


        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (moodscb.Text == "ÚJ HANGULAT" && newmoodtb.Text!="")
            {
                bool checker = false;
                for (int i = 0; i < Moods.Length; i++)
                {
                    if (Moods[i].mood.ToLower() == newmoodtb.Text.ToLower())
                    {
                        checker = true;
                        break;
                    }
                }
                if (checker)
                {
                    MessageBox.Show("Ez a hangulat már létezik!");
                }
                else
                {
                    Mood newmood = new Mood();
                    newmood.mood = newmoodtb.Text;
                    restapihandler.CreateMood(newmood);
                    moodscb.Items.Add(newmoodtb.Text);
                    MessageBox.Show("Új hangulat hozzáadva!");
                }
            }
        }
    }
}

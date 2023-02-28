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
        public petmood_administration()
        {
            InitializeComponent();
            for (int i = 0; i < Moods.Count; i++)
            {
                moodscb.Items.Add(Moods[i]);
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
                string ind = moodscb.Text;
                for (int i = 0; i < Moods.Count; i++)
                {
                    if (Moods[i].ToLower() == ind.ToLower())
                    {
                        Moods.RemoveAt(i);
                    }
                }
                moodscb.Items.Remove(ind);
            }
        }

        private void moodscb_DropDownClosed(object sender, EventArgs e)
        {
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (moodscb.Text == "ÚJ HANGULAT" && newmoodtb.Text!="")
            {
                Moods.Add(newmoodtb.Text);
                moodscb.Items.Add(newmoodtb.Text);
            }
        }
    }
}

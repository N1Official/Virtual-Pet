using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Administration
{
    internal class Pet
    {
        public List<string> Types = new List<string>
        {
            "tiger",
            "panther",
            "lion",
            "snake",
            "dog",
            "cat",
            "hamster"
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
        //These are temporarly while the backend is on developing
        private string name;
        private string type;
        private int hunger;
        private int thirst;
        private string mood;
        private int speed;
        private int health;
        private int skill;
        private int age;
        private string age_group;

        public string Name { get => name; set => name = value; }
        public int Hunger 
        { 
            get => hunger;
            set 
            {
                if (value<0)
                {
                    MessageBox.Show("Negatív nem lehet az éhségszint!");
                }
                else
                {
                    hunger = value;
                }
            } 
        }
        public int Thirst 
        {
            get => thirst;
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Negatív nem lehet a szomjúság!");
                }
                else
                {
                    thirst = value;
                }
            }
        }
        public string Mood 
        { 
            get => mood;
            set
            {
                if (Moods.Contains(value.ToLower()))
                {
                    mood = value;
                }
                else
                {
                    MessageBox.Show("A megadott kedv még nincs hozzáadva!");
                }
            }
        }
        public int Speed
        {
            get => speed;
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Nulla, illetve annál kisebb nem lehet a gyorsaság!");
                }
                else
                {
                    speed = value;
                }
            }
        }
        public int Health 
        {
            get => health;
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Nulla, illetve annál kisebb nem lehet az egészség!");
                }
                else
                {
                    health = value;
                }
            }
        }
        public int Skill 
        { 
            get => skill;
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Negatív nem lehet az ügyeszség!");
                }
                else
                {
                    skill = value;
                }
            }
        }
        public int Age 
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Negatív nem lehet a kor!");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Age_group 
        {
            get => age_group;
            set 
            {
                if (age<100 || value=="Kölyök")
                {
                    value = "Kölyök";
                    age_group = value;
                }
                if ((age>=100 && age<200) || value=="Felnőtt")
                {
                    value = "Felnőtt";
                    age_group = value;
                }
                if ((age >= 200 && age < 300) || value == "Öreg")
                {
                    value = "Öreg";
                    age_group = value;
                }
                if (age >299 || value=="Legendary")
                {
                    value = "Legendary";
                    age_group = value;
                }
                else
                {
                    MessageBox.Show("Hiba a korcsoport megadásakor!");
                }
            } 
        }
        public string Type 
        { 
            get => type;
            set 
            {
                if (Types.Contains(value.ToLower()))
                {
                    type = value;
                }
                else
                {
                    MessageBox.Show("A megadott típus még nem létezik!");
                }
            } 
        }
    }
}

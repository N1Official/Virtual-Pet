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
        
        //These are temporarly while the backend is on developing
        private int id;
        private int user_id;
        private string name;
        private string type;
        private double hunger;
        private double thirst;
        private string mood;
        private double speed;
        private double health;
        private double skill;
        private double age;
        private string age_group;
        public int Id { get => id; set => id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string Name { get => name; set => name = value; }
        public double Hunger 
        { 
            get => hunger;
            set 
            {
                if (value<0)
                {
                    MessageBox.Show("Negatív nem lehet az éhségszint!");
                }
                else if (value>10)
                {
                    value = 10;
                    hunger = value;
                    MessageBox.Show("Maximális éhségszint!");
                }
                else
                {
                    hunger = value;
                }
            } 
        }
        public double Thirst 
        {
            get => thirst;
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Negatív nem lehet a szomjúság!");
                }
                else if (value > 10)
                {
                    value = 10;
                    hunger = value;
                    MessageBox.Show("Maximális szomjúság!");
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
            set => name = value;
        }
        public double Speed
        {
            get => speed;
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Nulla, illetve annál kisebb nem lehet a gyorsaság!");
                }
                else if (value > 100)
                {
                    value = 100;
                    hunger = value;
                    MessageBox.Show("Maximális gyorsaság!");
                }
                else
                {
                    speed = value;
                }
            }
        }
        public double Health 
        {
            get => health;
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Nulla, illetve annál kisebb nem lehet az életerő!");
                }
                else if (value > 100)
                {
                    value = 100;
                    hunger = value;
                    MessageBox.Show("Maximális életerő!");
                }
                else
                {
                    health = value;
                }
            }
        }
        public double Skill 
        { 
            get => skill;
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Negatív nem lehet az ügyesség!");
                }
                else if (value > 100)
                {
                    value = 100;
                    hunger = value;
                    MessageBox.Show("Maximális ügyesség!");
                }
                else
                {
                    skill = value;
                }
            }
        }
        public double Age 
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
            set => age_group = value;
        }
        public string Type 
        { 
            get => type;
            set => type = value;
        }
        public Pet() { }
        public Pet(int id, int uid,string n, string t, double h, double th, string m, double s, double heal, double skill, double age, string ageg)
        {
            this.id = id;
            this.user_id = uid;
            this.name = n;
            this.type = t;
            this.hunger = h;
            this.thirst = th;
            this.mood = m;
            this.speed = s;
            this.health = heal;
            this.skill = skill;
            this.age = age;
            this.age_group = age_group;
        }
    }
}

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
        private int _id;
        private int _user_id;
        private string _name;
        private string _type;
        private double _hunger;
        private double _thirst;
        private string _mood;
        private double _speed;
        private double _health;
        private double _skill;
        private double _age;
        private string _age_group;
        public int id { get => _id; set => _id = value; }
        public int user_id { get => _user_id; set => _user_id = value; }
        public string name { get => _name; set => _name = value; }
        public double hunger 
        { 
            get => _hunger;
            set 
            {
                if (value<0)
                {
                    MessageBox.Show("Negatív nem lehet az éhségszint!");
                }
                else if (value>10)
                {
                    value = 10;
                    _hunger = value;
                    MessageBox.Show("Maximális éhségszint!");
                }
                else
                {
                    _hunger = value;
                }
            } 
        }
        public double thirst 
        {
            get => _thirst;
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
                    _thirst = value;
                }
            }
        }
        public string mood 
        { 
            get => _mood;
            set => _mood = value;
        }
        public double speed
        {
            get => _speed;
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Nulla, illetve annál kisebb nem lehet a gyorsaság!");
                }
                else if (value > 100)
                {
                    value = 100;
                    _speed = value;
                    MessageBox.Show("Maximális gyorsaság!");
                }
                else
                {
                    _speed = value;
                }
            }
        }
        public double health 
        {
            get => _health;
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Nulla, illetve annál kisebb nem lehet az életerő!");
                }
                else if (value > 100)
                {
                    value = 100;
                    _health = value;
                    MessageBox.Show("Maximális életerő!");
                }
                else
                {
                    _health = value;
                }
            }
        }
        public double skill 
        { 
            get => _skill;
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Negatív nem lehet az ügyesség!");
                }
                else if (value > 100)
                {
                    value = 100;
                    _skill = value;
                    MessageBox.Show("Maximális ügyesség!");
                }
                else
                {
                    _skill = value;
                }
            }
        }
        public double age 
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Negatív nem lehet a kor!");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public string age_group 
        {
            get => _age_group;
            set => _age_group = value;
        }
        public string type 
        { 
            get => _type;
            set => _type = value;
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

﻿using System;
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

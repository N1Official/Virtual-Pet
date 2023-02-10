using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Administration
{
    internal class User
    {
        private string id;
        private string name;
        private string email;
        private string password;
        private string firstName;
        private string lastName;
        private string gender;
        private string birthday;
        private string phone;
        private string address;
        private string city;
        private string state;
        private int zipcode;
        private string country;

        public string Id { get => id;}
        public string Name { get => name; set => name = value; }
        public string Email
        { 
            get => email;
            set{
                static bool IsValidEmail(string mail)
                {
                    try
                    {
                        var addr = new System.Net.Mail.MailAddress(mail);
                        return addr.Address == mail;
                    }
                    catch
                    {
                        return false;
                    }
                }
                bool isOk = IsValidEmail(value);
                if (isOk)
                {
                    email = value;
                }
                else
                {
                    MessageBox.Show("Hibás email cím!");
                }
            } 
        }
        public string Password { get => password; set => password = value; }
        public string FirstName 
        { 
            get => firstName;
            set {
                bool result;
                result = Char.IsUpper(value, 0);
                if (result)
                {
                    firstName = value;
                }
                else
                {
                    string big = (value.ToUpper());
                    firstName = big.Substring(0, 1) + value.Substring(1);
                }
            } 
        }
        public string LastName
        { 
            get => lastName;
            set
            {
                bool result;
                result = Char.IsUpper(value, 0);
                if (result)
                {
                    lastName = value;
                }
                else
                {
                    string big = (value.ToUpper());
                    lastName = big.Substring(0, 1) + value.Substring(1);
                }
            }
        }
        public string Gender 
        { 
            get => gender;
            set 
            {
                if (value == "ferfi" || value == "férfi" || value == "male" || value == "Male" || value == "Férfi")
                {
                    gender = value;
                }
                else if (value == "no" || value == "nő" || value == "Female" || value == "female" || value == "Nő")
                {
                    gender = value;
                }
                else
                {
                    MessageBox.Show("Hibás nem!");
                }
            }
        }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Phone 
        { 
            get => phone;
            set
            {
                if (value.StartsWith("+"))
                {
                    phone = value;
                }
                else
                {
                    MessageBox.Show("Kérem országos hívószámmal adja meg a telefonszámot!");
                }
            }
        }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public int Zipcode 
        { 
            get => zipcode;
            set
            {
                try
                {
                    zipcode = value;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Valami hiba történt: {0}", ex.Message);
                }

            }
        }
        public string Country { get => country; set => country = value; }
    }
}

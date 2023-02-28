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
        private int _id;
        private string _pets_id;
        private string _username;
        private string _email;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _gender;
        private DateTime _birthday;
        private string _phone;
        private string _address;
        private string _city;
        private string _state;
        private int _zipcode;
        private string _country;

        public int id { get => _id; set => _id = value; }
        public string pets_id { get => _pets_id; set => _pets_id = value; }
        public string username { get => _username; set => _username = value; }
        public string email
        { 
            get => _email;
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
                    _email = value;
                }
                else
                {
                    MessageBox.Show("Hibás email cím!");
                }
            } 
        }
        public string password { get => _password; set => _password = value; }
        public string firstName 
        { 
            get => _firstName;
            set {
                bool result;
                result = Char.IsUpper(value, 0);
                if (result)
                {
                    _firstName = value;
                }
                else
                {
                    string big = (value.ToUpper());
                    _firstName = big.Substring(0, 1) + value.Substring(1);
                }
            } 
        }
        public string lastName
        { 
            get => _lastName;
            set
            {
                bool result;
                result = Char.IsUpper(value, 0);
                if (result)
                {
                    _lastName = value;
                }
                else
                {
                    string big = (value.ToUpper());
                    _lastName = big.Substring(0, 1) + value.Substring(1);
                }
            }
        }
        public string gender 
        { 
            get => _gender;
            set 
            {
                if (value == "ferfi" || value == "férfi" || value == "male" || value == "Male" || value == "Férfi")
                {
                    _gender = "Férfi";
                }
                else if (value == "no" || value == "nő" || value == "Female" || value == "female" || value == "Nő")
                {
                    _gender = "Nő";
                }
                else
                {
                    MessageBox.Show("Hibás nem!");
                }
            }
        }
        public DateTime birthday { get => _birthday; set => _birthday = value; }
        public string phone 
        { 
            get => _phone;
            set
            {
                if (value.StartsWith("+"))
                {
                    _phone = value;
                }
                else
                {
                    MessageBox.Show("Kérem országos hívószámmal adja meg a telefonszámot!");
                }
            }
        }
        public string address { get => _address; set => _address = value; }
        public string city { get => _city; set => _city = value; }
        public string state { get => _state; set => _state = value; }
        public int zipcode 
        { 
            get => _zipcode;
            set
            {
                try
                {
                    _zipcode = value;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Valami hiba történt: {0}", ex.Message);
                }

            }
        }
        public string country { get => _country; set => _country = value; }

    }
}

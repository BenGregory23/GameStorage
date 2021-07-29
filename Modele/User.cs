using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class User
    {
        public string Name { get; private set; }

        public string Login { get; private set; }

        private string Password { get; set; }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }

        public override string ToString()
        {
            return $"{Name}\t{Login}\t {Password}\n";
        }

        public bool checkPassword(string password)
        {
            if (Password == password)
            {
                return true;
            }
            else return false;
        }
    }
}

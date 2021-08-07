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

        public HashSet<Game> FavouriteGames { get; private set; }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
            FavouriteGames = new HashSet<Game>();
        }

        public User(string name, string login, string password,  Game g)
            :this( name,  login,  password)
        {
            AddFavourite(g);
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

        public void AddFavourite(Game g)
        {
            FavouriteGames.Add(g);
        }

        public void RemoveFavourite(Game g)
        {
            FavouriteGames.Remove(g);
        }

    }
}

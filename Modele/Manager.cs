using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;




namespace Modele  
{
    public class Manager : ObservableObject
    { 
        public Game SelectedGame { get; set; }

        public ReadOnlyCollection<Game> Games
        {
            get;
            private set;
        }
        public static List<Game> games = new List<Game>();

        public ReadOnlyCollection<User> Users
        {
            get;
            private set; 
        }
        public static List<User> users = new List<User>();
        public bool IsUserConnected
        {
            get
            {
                return isUserConnected;
            }
            set
            {
                isUserConnected = value;
                OnPropertyChanged(nameof(isUserConnected));
            }
        }

        private bool isUserConnected;

        public User ConnectedUser { get; set; }

        /// <summary>
        /// Cet IEnumerable contient les jeux qui seront affichés dans UCHome, en utilisant linq on peut modifier l'ordre de filtrage 
        /// </summary>
        public static IEnumerable<Game> DisplayedGames { get; set; }

        public static HashSet<Game> FavouriteGames { get; set; }


        /// <summary>
        /// Dépendance vers le gestionnaire de persistance
        /// </summary>
        public IPersistanceManager Persistance { get; private set; }

        ///ZONE CONCERNANT LES UTILISATEURS

        

       public Manager(IPersistanceManager persistance)
       {
            Games = new ReadOnlyCollection<Game>(games);
            Users = new ReadOnlyCollection<User>(users);
            Persistance = persistance;

       }

        /// <summary>
        /// Méthode de chargement des données 
        /// </summary>
        public void LoadData()
        {
            var data = Persistance.LoadData();

            //we clear the list to have no twins or so 
            games.Clear();

            foreach(var g in data.Games)
            {
                games.Add(g);
            }
            

            users.Clear();

            foreach (var u in data.Users)
            {
                users.Add(u);
            }

            
            SelectedGame = games[0];
            DisplayedGames = games.OrderBy(g => g.Name);

        }

        public void GetFavouritesGames()
        {
            if (IsUserConnected == false) return;
            FavouriteGames = ConnectedUser.FavouriteGames;
        }

        /// <summary>
        /// Méthode servant à évaluer si le chargement des données à bien été fait 
        /// </summary>
        /// <returns></returns>
        public string ShowData()
        {
            string data = "";

            foreach(Game g in Games)
            {
                data += g.ToString();
            }

            foreach (User u in Users)
            {
                data += u.ToString();
            }

            return data;
        }
        
        public void CreateNewUser(string name, string login, string password)
        {
            if (users.Contains(new User(name, login, password))) return;
            User u = new User(name, login, password);
            users.Add(u);
            ConnectedUser = u;


        }
        
        public void SearchGame(string input, string uc)
        {
            Search s = new Search();
            if (uc.Equals("UCHome")) s.SearhByName(input);
            else if (uc.Equals("UCFavourites")) s.SearhByNameFavourites(input);
        }

        public void AddGameToFavourite()
        {
            ConnectedUser.AddFavourite(SelectedGame);
        }

        public void RemoveGameToFavourite()
        {
            ConnectedUser.RemoveFavourite(SelectedGame);
        }


    }
}

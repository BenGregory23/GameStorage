using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Modele
{
    public class Search
    {
        /// <summary>
        /// Permet la recherche de jeu dans la liste des jeux de l'accueil ou alors dans les favoris.
        /// </summary>
        /// <param name="input"></param>
        public void SearhByName(string input)
        {
            Manager.DisplayedGames = Manager.games.Where(g => g.Name.ToLower().Contains(input));
            
        }

        public void SearhByNameFavourites(string input)
        {
            Manager.DisplayedGames = Manager.FavouriteGames.Where(g => g.Name.ToLower().Contains(input));

        }
    }
}

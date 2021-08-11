using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public interface IPersistanceManager
    {

        ///// <summary>
        ///// Méthode pour le chargement des bières et utilisateurs
        ///// </summary>
        ///// <returns> Une collection de bières et une collection d'utiisateurs </returns>
        (IEnumerable<Game> Games, IEnumerable<User> Users) LoadData();


        public void SaveGame(Game g);

        public void SaveUser(User u);





    }
}

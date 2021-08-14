using System;
using System.Collections.Generic;
using Modele;

namespace StubPers
{
    public class Stub : IPersistanceManager
    {
       
        public List<Game> LoadGames()
        {
          List<Game> GameList = new List<Game>();
           

            //GameList.Add(new Game("Valorant", "2020", "FPS, Action, Competitive", "RIOT", "./image/GamesCover/valorant.jpg", "Competitive game", "https://www.youtube.com/watch?v=e_E9W2vsRbQ"));
            //GameList.Add(new Game("CSGO", "2012", "FPS, Action, Competitive", "Valve", "./image/GamesCover/CSGO.jpg", "Counter-Strike: Global Offensive (CS:GO) is a multiplayer first-person shooter developed by Valve and Hidden Path Entertainment. It is the fourth game in the Counter-Strike series. Developed for over two years, Global Offensive was released for Windows, macOS, Xbox 360, and PlayStation 3 in August 2012, and for Linux in 2014.", "https://www.youtube.com/watch?v=edYCtaNueQY"));
            //GameList.Add(new Game("Rocket League", "2010", "Action, Competitive", "Psyonix", "./image/GamesCover/rocket_league.jpg", "Rocket League is a vehicular soccer video game developed and published by Psyonix. The game was first released for Microsoft Windows and PlayStation 4 in July 2015, with ports for Xbox One and Nintendo Switch being released later on. In June 2016, 505 Games began distributing a physical retail version for PlayStation 4 and Xbox One, with Warner Bros. Interactive Entertainment taking over those duties by the end of 2017. Versions for macOS and Linux were also released in 2016, but support for their online services was dropped in 2020. The game went free-to-play in September 2020. ", "https://www.youtube.com/watch?v=SgSX3gOrj60&t=5s"));
            //GameList.Add(new Game("Red Dead 2", "2018", " Action, Adventure", "Rockstar", "./image/GamesCover/red_dead_2.jpg", "Red Dead Redemption 2 is a 2018 action-adventure game developed and published by Rockstar Games. The game is the third entry in the Red Dead series and is a prequel to the 2010 game Red Dead Redemption. The story is set in 1899 in a fictionalized representation of the Western, Midwestern, and Southern United States and follows outlaw Arthur Morgan, a member of the Van der Linde gang. Arthur must deal with the decline of the Wild West whilst attempting to survive against government forces, rival gangs, and other adversaries.", "https://www.youtube.com/watch?v=gmA6MrX81z4"));
            //GameList.Add(new Game("Trackmania", "2021", "Competitive, Racing", "Ubisoft", "./image/GamesCover/trackmania.jpg", "TrackMania is a series of racing games for Windows, PlayStation 4, Xbox One, Nintendo DS and Wii developed by Nadeo and Firebrand Games. Instead of following the usual trend of choosing a set car and track to play the game, in TrackMania the players can create their own tracks using a building block", "https://www.youtube.com/watch?v=TQQOwnbuvsc"));
            
            return GameList; 
        }

        public List<User> LoadUsers()
        {
            List<User> Users = new List<User>();

            //Users.Add(new User("Ben GREGORY", "benchoco", "banana"));
            //Users.Add(new User("Test HashSet", "test", "test", new Game("wow", "20/06/2020", "Survival", "Ben", "./image/GamesCover/Valorant.png")));

            return Users;
        }

        public (IEnumerable<Game> Games, IEnumerable<User> Users) LoadData()
        {
            List<Game> Games = LoadGames();
            List<User> Users = LoadUsers();

            return (Games, Users);
        }

        public void SaveGame(Game g)
        {
            throw new NotImplementedException();
        }

        public void SaveUser(User u)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user, Game game)
        {
            throw new NotImplementedException();
        }
    }
}

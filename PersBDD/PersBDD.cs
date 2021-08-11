using System;
using System.Collections.Generic;
using Modele;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Database
{
    public class PersBDD : IPersistanceManager
    {
        /// <summary>
        /// DataBase
        /// </summary>
        private IMongoDatabase db;

        public PersBDD()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://benchoco:choco2323@cluster0.sxz8t.mongodb.net/Cluster0?retryWrites=true&w=majority");
            db = dbClient.GetDatabase("GameStocker");
            Console.WriteLine("Successful connection!");
        }

        /// <summary>
        /// Method to load data from the database, in this case its games and users
        /// </summary>
        /// <returns></returns>
        public (IEnumerable<Game> Games, IEnumerable<User> Users) LoadData()
        {
            var collectionUser = db.GetCollection<User>("Users");
            var collectionGame = db.GetCollection<Game>("Games");

            List<User> Users = collectionUser.Find(new BsonDocument()).ToList();
            List<Game> Games = collectionGame.Find(new BsonDocument()).ToList();

            return (Games, Users);
        }

        /// <summary>
        /// Is used to insert a new game into the database.
        /// </summary>
        /// <param name="g">Game to insert</param>
        public void SaveGame(Game g)
        {
            var collection = db.GetCollection<Game>("Games");
            collection.InsertOne(g);
        }

        /// <summary>
        /// Is used to insert a new user into the database.
        /// </summary>
        /// <param name="u">User to insert</param>
        public void SaveUser(User u)
        {
            var collection = db.GetCollection<User>("Users");
            collection.InsertOne(u);
        }
    }
}

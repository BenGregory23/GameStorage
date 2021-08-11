using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Modele
{
    public class Game
    {
        public int Id { get; private set; }

        public static int LastId { get; private set; }

        public string Name { get; private set; }

        public string DateOfRelease { get; private set; }

        /// <summary>
        /// Propriété donnant le type du jeu (fps, action, online, co-op, indé etc...)
        /// </summary>
        public List<EnumType> Genres { get; private set; }

        public string Publisher { get; private set; }

        public double AverageRate { get; private set; }

        public string CoverImage { get; private set; }

        public bool IsTrailer { get; set; }

        /// <summary>
        /// Trailer of the game, its given under a normal youtube link and it's modified to be like a youtube embed video
        /// </summary>
        public string Trailer { get; set; }
   

        public string Description { get; private set; }

        public double Grade { get; private set; }

        public Game(string name, string dateOfRelease, List<EnumType> genres, string publisher, string coverImage)
        {
            Name = name;
            DateOfRelease = dateOfRelease;
            Genres = new List<EnumType>();
            Publisher = publisher;
            CoverImage = coverImage;
            Description = "This description will be available soon!";
            LastId++;
            Id = LastId;
            IsTrailer = false;
            
        }

        public Game(string name, string dateOfRelease, List<EnumType> genres, string publisher, string coverImage, string description)
            : this(name, dateOfRelease, genres, publisher, coverImage)
        {
            Description = description;
        }

        public Game(string name, string dateOfRelease, List<EnumType> genres, string publisher, string coverImage, string description, string trailer)
            : this(name, dateOfRelease, genres, publisher, coverImage)
        {
            Description = description;
            IsTrailer = true;
            string[] linkParts = trailer.Split("v=");
            Trailer = "https://www.youtube.com/embed/" + linkParts[1];

        }

        
        public override string ToString()
        {
            return $"{Name}\t {DateOfRelease} \t {Genres} \t {Publisher}\t {Trailer}\n";
        }


        /// <summary>
        /// couple de fonction Equals pour les protocoles d'égalités
        /// </summary>
        /// <param name="other"> C'est l'objet que l'on veut comparer</param>
        /// <returns> ?? </returns>
        public bool Equals([AllowNull] Game other)
        {
            return Name.Equals(other.Name);
        }

        


    }
}

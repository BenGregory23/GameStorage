using System;
using System.Diagnostics.CodeAnalysis;

namespace Modele
{
    public class Game
    {
        public string Name { get; private set; }

        public string DateOfRelease { get; private set; }

        /// <summary>
        /// Propriété donnant le type du jeu (fps, action, online, co-op, indé etc...)
        /// </summary>
        public string Type { get; private set; }

        public string Publisher { get; private set; }

        public double AverageRate { get; private set; }

        public string CoverImage { get; private set; }

        /// <summary>
        /// Trailer of the game, its given under a normal youtube link and it's modified to be like a youtube embed video
        /// </summary>
        public string Trailer
        {
            get
            {
                return trailer;
            }

            private set
            {
                string[] linkParts = value.Split("=");
                trailer = "https://www.youtube.com/embed/" + linkParts[1];
            }
        }
        private string trailer;

        public string Description { get; private set; }

        public Game(string name, string dateOfRelease, string type, string publisher, string coverImage)
        {
            Name = name;
            DateOfRelease = dateOfRelease;
            Type = type;
            Publisher = publisher;
            CoverImage = coverImage;
            Description = "This description will be available soon!";
        }

        public Game(string name, string dateOfRelease, string type, string publisher, string coverImage, string description)
            : this(name, dateOfRelease, type, publisher, coverImage)
        {
            Description = description;
        }

        public Game(string name, string dateOfRelease, string type, string publisher, string coverImage, string description, string trailer)
            : this(name, dateOfRelease, type, publisher, coverImage)
        {
            Description = description;
            Trailer = trailer;
        }

        
        public override string ToString()
        {
            return $"{Name}\t {DateOfRelease} \t {Type} \t {Publisher}\t {Trailer}\n";
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

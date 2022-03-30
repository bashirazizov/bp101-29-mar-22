using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    class Song
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 100)
                {
                    _name = value;
                }
            }
        }
        private string _genre;
        public string Genre
        {
            get { return _genre; }
            set
            {
                string[] allowedGenres = { "pop", "rock", "jazz", "techno" };
                if (allowedGenres.Contains(value.ToLower()))
                {
                    _genre = value;
                }
            }
        }
        public Singer Singer { get; set; }

        private int[] Ratings = new int[0];

        public void AddRating(byte rating)
        {
            if (rating>=0&&rating<=5)
            {
                Array.Resize(ref Ratings, Ratings.Length+1);
                Ratings[Ratings.Length - 1] = rating;
            }
        }

        public double GetAverageRating()
        {
            return Ratings.Average();
        }
    }
}

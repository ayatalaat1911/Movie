using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Project.Entities
{
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Time { get; set; }
        public string Language { get; set; }
        public DateTime Date { get; set; }
        public string MovieCountry { get; set; }

        /// <summary>
        /// Relations 
        /// 1) Many to Many With Actor Using MoviCast
        /// 2) Many to Many With Director Using MovieDirection
        /// 3) Many to Many With Reviewer Using Rating
        /// 4) Many to Many With Genre Using MovieGenre
        /// </summary>
        public ICollection<Actor> Actors { get; set; }
        public List<MovieCast> MovieCasts { get; set; }
        public ICollection<Director> Directors { get; set; }
        public List<MovieDirection> MovieDirections { get; set; }
        public List<Rating> Ratings { get; set; }
        public ICollection<Reviewer> Reviewers { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
        public ICollection<Genre> Genres { get; set; }

    }
}

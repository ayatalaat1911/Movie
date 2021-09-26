using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Project.Entities
{
    class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}

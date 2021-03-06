using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Project.Entities
{
    class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public List<MovieCast> MovieCasts { get; set; }


    }
}

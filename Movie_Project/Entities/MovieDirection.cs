using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Project.Entities
{
    class MovieDirection
    {
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}

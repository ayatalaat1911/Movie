using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Project.Entities
{
    class Rating
    {
        public int Stars { get; set; }
        public int NumOfRating { get; set; }
        public Reviewer Reviewer { get; set; }
        public int ReviewerId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}

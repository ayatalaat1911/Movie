﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Project.Entities
{
    class Reviewer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Rating> Ratings { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}

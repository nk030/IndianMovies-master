using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndianMovies.Models
{
    public class MoviesCollection
    {
        [Key]

        public int Moviescollection_Id { get; set; } // This is the primary key

        public string Movie_Name { get; set; } // movie name

        public string India { get; set; } // this is rank in india

        public string Canada { get; set; } // this is rank in canada

        public string Australia { get; set; } // this is rank in Australia


        // Foreign Key

        public int Movie_ID { get; set; }

        public Movies Movie_obj { get; set; }
    }
}

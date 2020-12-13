using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndianMovies.Models
{
    public class Movies
    {
        [Key]

        public int Movie_Id { get; set; } // This is the primary key



        public string Movie_Name { get; set; } // this is the movie name



        public string Director_Name { get; set; } // this is name of director



        public string Actor_Name { get; set; } // this is name of actor


        public string Actress_Name { get; set; } // this is name of actress



        public DateTime Release_Date { get; set; } // This is Release date


    }
}

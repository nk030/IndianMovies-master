using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndianMovies.Models
{
    public class UpcomingMovies
    {


        [Key]

        public int UpcomingMovies_Id { get; set; } // This is the primary key



        public string Movie_Name { get; set; } // this ia movie name

        public string Movie_Type { get; set; } // this is the type of movie



        public DateTime Release_Date { get; set; } // this is movie release date



       



        // Foreign Key



        public int Movie_ID { get; set; }



        public Movies Movie_obj { get; set; }
    }
}

using eTicket.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Movie
    {
        [Key]
        public int Movie_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }

        //cinema
        [ForeignKey("Cinema_Id")]
        public  int Cinema_Id { get; set; }        
        public Cinema Cinema { get; set; }

        //Producer
        [ForeignKey("Producer_Id")]
        public int Producer_Id { get; set; }
        public Producer Producer { get; set; }
    }
}

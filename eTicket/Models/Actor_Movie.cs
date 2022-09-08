using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Actor_Movie
    {        
                
        public int Movie_Id { get; set; }
        public Movie Movie { get; set; }        
        public int Actor_Id { get; set; }
        public Actor Actor { get; set; }
    }
}

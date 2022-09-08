using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class OrderItems
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }


        [ForeignKey("MovieId")]
        public int Movie_Id { get; set; }        
        public Movie Movie { get; set; }
        public int Order_Id { get; set; }
        [ForeignKey("Order_Id")]
        public Order Order { get; set; }
    }
}

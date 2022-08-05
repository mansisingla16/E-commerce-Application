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
        public int MovieId { get; set; }        
        public Movie Movie { get; set; }


        [ForeignKey("OrderId")]
        public int OrderId { get; set; }        
        public Order Order { get; set; }
    }
}

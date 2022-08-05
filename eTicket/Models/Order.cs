using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }
        [ForeignKey("MovieId")]
        public int Movie_Id { get; set; }          
        [ForeignKey("CinemaId")]
        public int Cinema_Id { get; set; }
        public int Quantity { get; set; }


        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public List<OrderItems> OrderItems { get; set; }        

    }
}

 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Movie_Id { get; set; }
       // public Movie Movie { get; set; }
        //public int Amount { get; set; }
        public int ShoppingCartId { get; set; }
        public Order Order { get; set; }
    }
}

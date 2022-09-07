
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

    namespace eTicket.Models
{
        public class Seat
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public int Seats { get; set; }

        // public DateTime Date { get; set; }

        // public string Booking_Status { get; set; }

    }
}


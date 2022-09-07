using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public int Cinema_Id { get; set; }
        public int SeatNo { get; set; }
        public string Date { get; set; }
        public string BookingStatus { get; set; }
        public string UserName { get; set; }
        public string UserPhoneNo { get; set; }
        public string PaymentReferenceId { get; set; }
        public string PaymentStatus { get; set; }
        //public int Seat { get; set; }

    }
}


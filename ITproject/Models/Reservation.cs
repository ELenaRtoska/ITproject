using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITproject.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public List<TimeSlot> TimeSlots { get; set; }
        public Client ClientId { get; set; }

        public List<Seat> Seats { get; set; }

        public Reservation()
        {
            Seats = new List<Seat>();
            TimeSlots = new List<TimeSlot>();
        }
    }
}
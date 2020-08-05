using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITproject.Models
{
    public class Seat
    {
        [Key]
        public int SeatNumber { get; set; }
        public Boolean SeatStatus { get; set; }

        public Building buildingId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITproject.Models
{
    public class TimeSlot
    {
        [Key]
        public DateTime Slot { get; set; }
        public Boolean TimeSlotStatus { get; set; }

        public Building buildingId { get; set; }

        public Performance performanceId { get; set; }
    }
}
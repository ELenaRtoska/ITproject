using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITproject.Models
{
    public class Building
    {
        [Key]
        public int BuildingId { get; set; }
        [Required]
        public string BuildingName { get; set; }
        [Range (0,1)] //0-teatar 1-balet
        public int BuildingStutus { get; set; }
        [Required]
        public int NumberOfSeats { get; set; }
    }
}
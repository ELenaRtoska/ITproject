using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITproject.Models
{
    public class Performance
    {
        [Key]
        public int PerformanceId { get; set; }
        [Required]
        public string PerformanceName { get; set; }

        public string Description { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITproject.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string ClientName { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
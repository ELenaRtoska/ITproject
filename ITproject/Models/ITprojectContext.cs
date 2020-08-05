using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITproject.Models
{
    public class ITprojectContext:DbContext
    {
        //DbSet<Building> Buildings { get; set; }
        //DbSet<Client> Clients { get; set; }
        //DbSet<Performance> Performances{ get; set; }
        //DbSet<Seat> Seats { get; set; }
        //DbSet<TimeSlot> TimeSlots { get; set; }


        public ITprojectContext() : base("ITprojectDB")
        {
        }
        public static ITprojectContext Create()
        {
            return new ITprojectContext();
        }

        public System.Data.Entity.DbSet<ITproject.Models.Building> Buildings { get; set; }

        public System.Data.Entity.DbSet<ITproject.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<ITproject.Models.Seat> Seats { get; set; }

        public System.Data.Entity.DbSet<ITproject.Models.TimeSlot> TimeSlots { get; set; }

        public System.Data.Entity.DbSet<ITproject.Models.Performance> Performances { get; set; }
    }
}
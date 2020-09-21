using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DTPRegistration.Models
{
    public class DTPContext:DbContext
    {
        public DbSet<DTPType> Types { get; set; }
        public DbSet<DTPRegistr> Registrations { get; set; }
    }
}
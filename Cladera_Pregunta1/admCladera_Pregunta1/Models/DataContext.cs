using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace admCladera_Pregunta1.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admCladera_Pregunta1.Models.Cladera> Claderas { get; set; }
    }
}
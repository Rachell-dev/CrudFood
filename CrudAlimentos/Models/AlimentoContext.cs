using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudAlimentos.Models
{
    public class AlimentoContext: DbContext
    {

        public AlimentoContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<alimento> Alimentos { get; set; }
    }
}
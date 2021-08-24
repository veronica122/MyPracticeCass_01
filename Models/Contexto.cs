using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyPracticeCass.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
    }
}
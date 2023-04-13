using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Escritorio.Form2;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq;

namespace Escritorio
{
    public class BiblioContext : DbContext
    {
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Autor> Autors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local)\\SQLEXPRESS;Initial Catalog=BiblioSuite;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}

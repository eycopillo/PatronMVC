using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace PatronMVC.Models
{
    public class departamentosContext: DbContext
    {
        public DbSet<Departamentos> Departamentos { get; set; }

        public departamentosContext(DbContextOptions<departamentosContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = MSI\\PEPE;Initial Catalog = Consultoria_Alteña; Integrated Security = True;TrustServerCertificate=True;");
        }

        
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
    public class ClientRezervareContext : DbContext
    {
        public DbSet<Client> Clienti { get; set; }
        public ClientRezervareContext()
        {
            try
            {
                Database.Migrate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=clienti.db");
        }
    }

}

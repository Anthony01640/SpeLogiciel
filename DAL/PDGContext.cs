using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
namespace DAL
{
    public class PDGContext : DbContext
    {
        public PDGContext(DbContextOptions<PDGContext> options)
            : base(options)
        {
        }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Champs> Champs { get; set; }
        public DbSet<Valeurs> Valeurs { get; set; }
    }
}

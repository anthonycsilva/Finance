using BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Context
{
    public class FinanceContext : DbContext 
    {
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<Conta> Conta { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ANTHONYWINDOWS; Database = Finance; Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

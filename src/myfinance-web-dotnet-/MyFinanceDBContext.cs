using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using myfinance_web_dotnet_.Domain.Entities;

namespace myfinance_web_dotnet_
{
    public class MyFinanceDBContext : DbContext

    { 
        public DbSet<PlanoConta> PlanoConta {get; set;}
        public DbSet<Transacao> Transacao {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionsString = @"Server=.\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionsString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        
    }
}
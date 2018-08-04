using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Domain.Entities.Inventory;

namespace Infraestructure.Context.Inventory
{
    public class InventoryDB:DbContext
    {
        // Install-Package Microsoft.EntityFrameworkCore.SqlServer
        static readonly string DEFAULT_CONNECTION_STRING = "data source=.;initial catalog=EntityFrameworkCore;integrated security=True";
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {              
                optionsBuilder.UseSqlServer(DEFAULT_CONNECTION_STRING);
            }
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStore.Models
{
    public class CandyStoreContext : DbContext
    {
        public CandyStoreContext()
        {

        }
        public virtual DbSet<Producer> Producers {get; set;}
        public virtual DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CandyStore;integrated security=True");
        }

        public CandyStoreContext(DbContextOptions<CandyStoreContext> options) : base(options)
            {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }
    }
}

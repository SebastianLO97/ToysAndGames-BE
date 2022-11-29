using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Seeders
{
    public static class SeedProduct
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Hot Wheels", AgeRestriction = 3, Price = 32M, CompanyId = 1 },
                new Product { Id = 2, Name = "Barbie", AgeRestriction = 4, Price = 99.99M, CompanyId = 1 },
                new Product { Id = 3, Name = "Turista", AgeRestriction = 8, Price = 130.50M, CompanyId = 2 }
            );
        }
    }
}

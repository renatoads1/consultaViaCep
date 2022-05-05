using consomeApiCep.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace consomeApiCep.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Enderecos> Enderecos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseMySql(@"Server=localhost;database=cepapienderecos;uid=root;pwd=r3n4t0321");
    }
}

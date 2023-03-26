using System;
using System.Data;
using Models;
using Microsoft.EntityFrameworkCore;

namespace Context
{
    public class CartContext : DbContext
    {
        public CartContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BasicData> BasicData { get; set; }
    }
}

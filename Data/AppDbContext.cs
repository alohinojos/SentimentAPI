using Microsoft.EntityFrameworkCore;
using SentimentAPI.Models;
using System.Collections.Generic;

namespace SentimentAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; } = null!;
    }
}
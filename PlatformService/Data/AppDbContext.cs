using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace PlatformData
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option): base (option)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}

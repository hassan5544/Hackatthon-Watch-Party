using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
   
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        } 
    public DbSet<User>? Users { get; set; }
        public DbSet<Video>? Videos { get; set; }
        public DbSet<WatchParty>? WatchParties { get; set; }
    }
}

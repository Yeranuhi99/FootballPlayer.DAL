using Microsoft.EntityFrameworkCore;
using Player.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.DAL
{
    public class FootballPlayerDBContext : DbContext
    {
        public FootballPlayerDBContext(DbContextOptions<FootballPlayerDBContext> options) : base(options) { }
        public DbSet<FootballPlayer> FootballPlayer { get; set; }
        public DbSet<Club> Club { get; set; }
    }
}

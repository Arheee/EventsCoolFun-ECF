using EventsCoolFun_ECF_.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EventsCoolFun_ECF_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){ }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Event> Events { get; set; }

      
    }
}

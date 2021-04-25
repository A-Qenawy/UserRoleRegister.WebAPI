using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>(a =>
            {
                a.HasKey(b => b.RoleId);
                a.Property(b => b.RoleId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<User>(a =>
            {
                a.HasKey(b => b.UserId);
                a.Property(b => b.UserId).ValueGeneratedOnAdd();
            });

            var newUser = new User()
            {
                UserId = 1,
                Name = "Ahmed QE",
                Email = "A@A.A",
                Password = "123",
            };

            var NewRole = new Roles()
            {
                RoleId = 1,
                Role_Name = "Admin",

            };
            var newUserRole = new UserRole()
            {
                Id = 1,
                RoleId = 1,
                UserId = 1
            };


            modelBuilder.Entity<User>().HasData(newUser);
            modelBuilder.Entity<Roles>().HasData(NewRole);
            modelBuilder.Entity<UserRole>().HasData(newUserRole);
        }

    }
}

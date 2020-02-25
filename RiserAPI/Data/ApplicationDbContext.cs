using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using RiserAPI.Models;
using RiserAPI.Models.Gear;
using RiserAPI.Models.Jump;
using RiserAPI.Models.Link;
using RiserAPI.Models.Link.Gear;
using RiserAPI.Models.Link.Jump;
using RiserAPI.Models.Store;
using RiserAPI.Models.User;

namespace RiserAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() 
        {
            
        }

        //Apply Fluent API Configurations.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JumpConfiguration());
        }

        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Base> Bases { get; set; }
        public DbSet<BaseJump> BaseJumps { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<GearItem> Gears { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Jump> Jumps { get; set; }
        public DbSet<JumpType> JumpTypes { get; set; }
        public DbSet<Malfunction> Malfunctions { get; set; }
        public DbSet<Rig> Rigs { get; set; }
        public DbSet<RigItemType> RigItemTypes { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SignOffRequest> SignOffRequests { get; set; }
        public DbSet<Skydive> Skydives { get; set; }
        public DbSet<SkydiveDiscipline> SkydiveDisciplines { get; set; }
        public DbSet<TunnelSession> TunnelSessions { get; set; }
        public DbSet<User> Users { get; set; }
        
        #region Linking Table
        public DbSet<GearImage> GearImages { get; set; }
        public DbSet<JumpGear> JumpGears { get; set; }
        public DbSet<JumpParticipant> JumpParticipants { get; set; }
        public DbSet<RigItem> RigItems { get; set; }
        #endregion
    }
}

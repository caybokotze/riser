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
using RiserAPI.Models.Link.Store;
using RiserAPI.Models.Link.User;
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
            modelBuilder.ApplyConfiguration(new GearItemConfiguration());
            modelBuilder.ApplyConfiguration(new GearTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new RigConfiguration());
            modelBuilder.ApplyConfiguration(new RigItemTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AircraftConfiguration());
            modelBuilder.ApplyConfiguration(new BaseJumpConfiguration());
            modelBuilder.ApplyConfiguration(new BaseJumpTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JumpConfiguration());
            modelBuilder.ApplyConfiguration(new JumpTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MalfunctionConfiguration());
            modelBuilder.ApplyConfiguration(new SkydiveConfiguration());
            modelBuilder.ApplyConfiguration(new SkydiveDisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new SkydiveTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TunnelSessionConfiguration());
            modelBuilder.ApplyConfiguration(new GearImageConfiguration());
            modelBuilder.ApplyConfiguration(new RigCollectionConfiguration());
            modelBuilder.ApplyConfiguration(new RigItemTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JumpGearConfiguration());
            modelBuilder.ApplyConfiguration(new JumpImageConfiguration());
            modelBuilder.ApplyConfiguration(new JumpMalfunctionConfiguration());
            modelBuilder.ApplyConfiguration(new JumpParticipantConfiguration());
            modelBuilder.ApplyConfiguration(new SignOffConfiguration());
            modelBuilder.ApplyConfiguration(new GearSaleImageConfiguration());
            modelBuilder.ApplyConfiguration(new ListedGearConfiguration());
            modelBuilder.ApplyConfiguration(new UserGearConfiguration());
            modelBuilder.ApplyConfiguration(new UserImageConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseInfoConfiguration());
            modelBuilder.ApplyConfiguration(new SaleConfiguration());
            modelBuilder.ApplyConfiguration(new SaleListingConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            //todo: licensetypeconfiguration
            modelBuilder.ApplyConfiguration(new SettingConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
           
        }

        public DbSet<Aircraft> Aircraft { get; set; }
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
        public DbSet<JumpParticipant> JumpParticipants { get; set; }
        public DbSet<RigCollection> RigCollections { get; set; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiserAPI.Models.Link.Jump;
using RiserAPI.Models.User;

namespace RiserAPI.Models.Jump
{
    public class Jump : Base
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(50)]
        public string LocationName { get; set; }
        
        public long Latitude { get; set; }
        
        public long Longitude { get; set; }

        public DateTime Date { get; set; }

        public bool IsPublic { get; set; }

        #region Navigations
        //User
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User.User User { get; set; }
        //JumpType
        [ForeignKey("JumpType")]
        public int JumpTypeId { get; set; }
        public JumpType JumpType { get; set; }
        //Sign Off Request
        public SignOffRequest SignOffRequest { get; set; }
        //Tunnel Session
        public TunnelSession TunnelSession { get; set; }
        //Base Jump
        public BaseJump BaseJump { get; set; }
        //Skydive
        public Skydive Skydive { get; set; }
        //Jump Participants
        public IEnumerable<JumpParticipant> JumpParticipants { get; set; }
        //Jump Images
        public IEnumerable<JumpImage> JumpImages { get; set; }
        //Comments
        public IEnumerable<Comment> Comments { get; set; }
        //Jump Gear
        public IEnumerable<JumpGearItem> JumpGearItems { get; set; }
        //Jump Malfunctions
        public IEnumerable<JumpMalfunction> JumpMalfunctions { get; set; }
        #endregion
    }

    public class JumpConfiguration : IEntityTypeConfiguration<Jump>
    {
        public void Configure(EntityTypeBuilder<Jump> builder)
        {
            builder.HasKey(k => k.Id);
            //User with many jumps
            builder.HasOne(k => k.User)
                .WithMany(w => w.Jumps)
                .HasForeignKey(f => f.UserId);
            //Jump with one JumpType.
            builder.HasOne(k => k.JumpType)
                .WithOne(w => w.Jump)
                .HasForeignKey<Jump>(f => f.JumpTypeId);
            //Todo: BaseJump, Skydive and have One to type Jump.
        }
    }
}

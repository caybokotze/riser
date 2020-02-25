﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace RiserAPI.Models.Link.Jump
{
    public class JumpParticipant
    {
        //User
        public int UserId { get; set; }
        public Models.User.User User { get; set; }
        //Jump
        public int JumpId { get; set; }
        public Models.Jump.Jump Jump { get; set; }
    }
    
    public class JumpParticipantConfiguration : IEntityTypeConfiguration<JumpParticipant>
    {
        public void Configure(EntityTypeBuilder<JumpParticipant> builder)
        {
            builder.HasKey(k => new
            {
                k.UserId,
                k.JumpId
            });
        }
    }
}
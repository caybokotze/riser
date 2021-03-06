﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiserAPI.Models.Jump
{
    public class SignOffRequest
    {
        //Jump
        public int JumpId { get; set; }
        public Jump Jump { get; set; }
        //Participant
        public int FromParticipantId { get; set; }
        public User.User FromUser { get; set; }
        //Participant
        public int ToParticipantId { get; set; }
        //
        public DateTime Date { get; set; }
    }
    
    public class SignOffConfiguration : IEntityTypeConfiguration<SignOffRequest>
    {
        public void Configure(EntityTypeBuilder<SignOffRequest> builder)
        {
            builder.HasKey(k => new
            {
                k.JumpId,
                k.FromParticipantId,
                k.ToParticipantId
            });
            //Map One to One => Jump > SignOff.
            builder.HasOne(h => h.Jump)
                .WithOne(o => o.SignOffRequest)
                .HasForeignKey<SignOffRequest>(f => f.JumpId).OnDelete(DeleteBehavior.NoAction);
            //Map One to One => From User.
            builder.HasOne(h => h.FromUser)
                .WithOne(w => w.SignOffRequest)
                .HasForeignKey<SignOffRequest>(f => f.FromParticipantId).OnDelete(DeleteBehavior.NoAction);
            //Map One to One => To User.
        }
    }
}
﻿using System.ComponentModel.DataAnnotations;

namespace RiserAPI.Models.User
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        //
        [Required]
        public string Text { get; set; }
        //
        public Jump.Jump Jump { get; set; }
        public int JumpId { get; set; }
        //
        public User User { get; set; }
        public string UserId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiserAPI.Models
{
    public abstract class Base : RiserAPI.Interfaces.Base
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
        //
        [Display(Name = "Updated At")]
        public DateTime UpdatedAt { get; set; }
    }
}

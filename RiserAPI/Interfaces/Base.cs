using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiserAPI.Interfaces
{
    public interface Base
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }

    }
}

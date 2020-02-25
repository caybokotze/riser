using System;
using RiserAPI.Data.Interfaces.Repository;

namespace RiserAPI.Data.Interfaces
{
    public interface IContextService : IDisposable
    {
        IGearRepository GearItems { get; }
    }
}
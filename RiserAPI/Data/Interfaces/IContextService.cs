using System;
using RiserAPI.Data.Interfaces.Repository;

namespace RiserAPI.Data.Interfaces
{
    public interface IContextService : IDisposable
    {
        IGearItemRepository GearItems { get; }
        IAircraftRepository Aircraft { get; }
    }
}
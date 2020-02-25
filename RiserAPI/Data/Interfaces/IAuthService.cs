using System.Collections.Generic;
using RiserAPI.Models;
using RiserAPI.Models.User;

namespace RiserAPI.Data.Interfaces
{
    public interface IAuthService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}
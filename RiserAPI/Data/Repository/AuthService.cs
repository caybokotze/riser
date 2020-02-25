using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RiserAPI.Data.Interfaces;
using RiserAPI.Extentions;
using RiserAPI.Models;
using RiserAPI.Models.User;


namespace RiserAPI.Data.Repository
{
    public class AuthService : IAuthService
    {
        private List<User> _users = new List<User>();
        private readonly AppSettings _appSettings;
        public AuthService(IOptions<AppSettings> appSettings)
        {
            
        }
        
        public User Authenticate(string username, string password)
        {
            //
            var user = _users.SingleOrDefault(s => s.Email == username && s.Hash == password.GetHashValue("1234"));
            //
            if (user == null) return null;
            //
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()) 
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user.WithoutPassword();
        }

        public IEnumerable<User> GetAll()
        {
            return _users.WithoutPasswords();
        }
    }
}
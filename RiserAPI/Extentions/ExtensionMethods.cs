using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using RiserAPI.Models;
using RiserAPI.Models.User;

namespace RiserAPI.Extentions
{
    public static class ExtensionMethods
    {
        public static string GetHashValue(this String value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(value));
            return hash.ToString();
        }
        public static string GetHashValue(this String value, string salt)
        {
            var md5 = new MD5CryptoServiceProvider();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(value + salt));
            return hash.ToString();
        }

        public static IEnumerable<User> WithoutPasswords(this IEnumerable<User> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static User WithoutPassword(this User user)
        {
            user.Hash = null;
            return user;
        }
    }
}
﻿using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace Basic_Authentication_System.Helpers
{
    public class PasswordHelper
    {
        //Hashing Password
        public string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            password = Convert.ToBase64String(hash);
            return password;
        }

        //Verifying password
        public bool VerifyPassword(string realPassword, string password)
        {
            var check = HashPassword(password);
            var result = (realPassword == check);
            return result;
        }

    }
}

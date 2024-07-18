using System;
using System.Security.Cryptography;

namespace FitnessTracker.helpers
{
    /// <summary>
    /// Helper class for hashing and verifying passwords using PBKDF2 with HMACSHA1.
    /// </summary>
    public static class Hasher
    {
        private const int SaltSize = 16;  // Size of salt in bytes
        private const int HashSize = 20;  // Size of hash in bytes
        private const int Iterations = 10000;  // Number of iterations for PBKDF2

        /// <summary>
        /// Hashes a password using PBKDF2 with HMACSHA1.
        /// </summary>
        /// <param name="value">The password to hash.</param>
        /// <returns>The hashed password as a base64-encoded string.</returns>
        public static string Hash(string value)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[SaltSize];  // Generate salt
                rng.GetBytes(salt);

                var pbkdf2 = new Rfc2898DeriveBytes(value, salt, Iterations);  // Create PBKDF2 instance
                byte[] hash = pbkdf2.GetBytes(HashSize);  // Generate hash
                byte[] hashBytes = new byte[SaltSize + HashSize];  // Combine salt and hash
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                return Convert.ToBase64String(hashBytes);  // Return hashed password
            }
        }

        /// <summary>
        /// Verifies if a password matches its hashed value.
        /// </summary>
        /// <param name="value">The password to verify.</param>
        /// <param name="hashedValue">The stored hashed password.</param>
        /// <returns>True if the password matches the hashed value, otherwise false.</returns>
        public static bool Verify(string value, string hashedValue)
        {
            byte[] hashBytes = Convert.FromBase64String(hashedValue);  // Convert hashed value from base64
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);  // Extract salt from hashed value

            var pbkdf2 = new Rfc2898DeriveBytes(value, salt, Iterations);  // Create PBKDF2 instance with extracted salt
            byte[] hash = pbkdf2.GetBytes(HashSize);  // Generate hash

            for (int i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])  // Compare generated hash with stored hash
                {
                    return false;  // Return false if hashes don't match
                }
            }
            return true;  // Return true if hashes match
        }
    }
}

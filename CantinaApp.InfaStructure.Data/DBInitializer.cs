using CantinaApp.Core.Entity.Entities;
using CantinaApp.Core.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.InfaStructure.Data
{
    public class DBInitializer
    {
        public static void SeedDb(CantinaAppContext ctx)
        {
            string password = "4321";
            byte[] passwordHashJoe, passwordSaltJoe, passwordHashAnn, passwordSaltAnn;
            CreatePasswordHash(password, out passwordHashJoe, out passwordSaltJoe);
            CreatePasswordHash(password, out passwordHashAnn, out passwordSaltAnn);

            List<Users> users = new List<Users>
            {
                new Users {
                    Username = "kris",
                    PasswordHash = passwordHashJoe,
                    PasswordSalt = passwordSaltJoe,
                    IsAdmin = true
                },
                new Users {
                    Username = "jacob",
                    PasswordHash = passwordHashAnn,
                    PasswordSalt = passwordSaltAnn,
                    IsAdmin = false
                }
            };

            var mainFood = ctx.MainFood.Add(new MainFood()
            {
                MainFoodName = "ChickenPizzaSoup"

            }).Entity;

            ctx.MainFood.AddRange(mainFood);
            ctx.User.AddRange(users);
            ctx.SaveChanges();
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}

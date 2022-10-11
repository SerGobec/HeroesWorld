using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Infrastructure
{
    public static class DefaultDataInitializer
    {
        public static void InitDefaultData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(GetDefaultUsers());
            modelBuilder.Entity<Character>().HasData(GetDefaultCharacters());
        }
        public static List<User> GetDefaultUsers()
        {
            return new List<User> { new User(){
                Id = 100,
                Username = "Melivor",
                Email = "Sergobec@gmail.com",
                Coins = 99999999999999999,
                Diamonds = 9999999999999999,
                Expirience = 0,
                Password = "1111",
                Role = UserRole.Admin,
                TelegramId = null
            }};
        }

        public static List<Character> GetDefaultCharacters()
        {
            return new List<Character> { new Character()
                {
                Id = 100,
                ChanceOfDropping = 40,
                Name = "Shikamaru",
                Quality = CharacterQuality.Ordinary
                }, new Character()
                {
                    Id = 101,
                    ChanceOfDropping = 30,
                    Name = "Saitama",
                    Quality = CharacterQuality.Powerful
                }, new Character()
                {
                    Id = 102,
                    Name = "Jojo",
                    ChanceOfDropping = 2,
                    Quality = CharacterQuality.Mithical
                }
            };
        }
    }
}

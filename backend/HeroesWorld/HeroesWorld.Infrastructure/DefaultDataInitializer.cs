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
            modelBuilder.Entity<Chest>().HasData(GetDefaultChest());
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

        public static List<Chest> GetDefaultChest()
        {
            return new List<Chest>()
            {
                new Chest()
                {
                    Id = 1,
                    Name = "Small box"
                },
                new Chest()
                {
                    Id =2,
                    Name = "Ordinar character box"
                }
            };
        }

        public static List<ChestOportunity> GetDefaultChestOp()
        {
            return new List<ChestOportunity>()
            {
                new ChestOportunity()
                {
                    ChestId = 1,
                    Count = 10000,
                    Prize = PrizeType.Coins,
                    Oportunity = 10
                },
                new ChestOportunity()
                {
                    ChestId = 1,
                    Count = 100000,
                    Prize = PrizeType.Coins,
                    Oportunity = 10
                },
                new ChestOportunity()
                {
                    ChestId = 1,
                    Count = 20000,
                    Prize = PrizeType.Coins,
                    Oportunity = 10
                },
                new ChestOportunity()
                {
                    ChestId = 1,
                    Count = 50000,
                    Prize = PrizeType.Coins,
                    Oportunity = 10
                },
                new ChestOportunity()
                {
                    ChestId = 1,
                    Count = 100,
                    Prize = PrizeType.Diamonds,
                    Oportunity = 30
                }, new ChestOportunity()
                {
                    ChestId = 1,
                    Count = 1,
                    Prize = PrizeType.CharacterQuality,
                    Oportunity = 27
                }, new ChestOportunity()
                {
                    ChestId = 1,
                    Count = 1,
                    Prize = PrizeType.SpecialCharacter,
                    Oportunity = 3
                }
            };
        }
    }
}

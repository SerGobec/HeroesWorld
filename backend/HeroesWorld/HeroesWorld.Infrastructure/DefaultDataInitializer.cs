using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace HeroesWorld.Infrastructure
{
    public static class DefaultDataInitializer
    {
        public static void InitDefaultData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(GetDefaultUsers());
            modelBuilder.Entity<Character>().HasData(GetDefaultCharacters());
            modelBuilder.Entity<Chest>().HasData(GetDefaultChest());
            modelBuilder.Entity<ChestOpportunity>().HasData(GetDefaultChestOp());
            modelBuilder.Entity<CharacterOfBox>().HasData(GetSpecCharacterOfBoxes());
            modelBuilder.Entity<CharacterQualityOfBox>().HasData(GetCharacterQualityOfBoxes());
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
                Id = 1,
                ChanceOfDropping = 40,
                Name = "Shikamaru",
                Quality = CharacterQuality.Ordinary
                }, new Character()
                {
                    Id = 2,
                    ChanceOfDropping = 30,
                    Name = "Saitama",
                    Quality = CharacterQuality.Powerful
                }, new Character()
                {
                    Id = 3,
                    Name = "Jojo",
                    ChanceOfDropping = 2,
                    Quality = CharacterQuality.Mithical
                },
                new Character() {
                    Id = 4,
                    Name = "Sasuke",
                    ChanceOfDropping = 1,
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

        public static List<ChestOpportunity> GetDefaultChestOp()
        {
            return new List<ChestOpportunity>()
            {
                new ChestOpportunity()
                {
                    Id = 1,
                    ChestId = 1,
                    Count = 10000,
                    Prize = PrizeType.Coins,
                    Oportunity = 10
                },
                new ChestOpportunity()
                {
                    Id = 2,
                    ChestId = 1,
                    Count = 100000,
                    Prize = PrizeType.Coins,
                    Oportunity = 10
                },
                new ChestOpportunity()
                {
                    Id = 3,
                    ChestId = 1,
                    Count = 20000,
                    Prize = PrizeType.Coins,
                    Oportunity = 10
                },
                new ChestOpportunity()
                {
                    Id = 4,
                    ChestId = 1,
                    Count = 50000,
                    Prize = PrizeType.Coins,
                    Oportunity = 10
                },
                new ChestOpportunity()
                {
                    Id = 5,
                    ChestId = 1,
                    Count = 100,
                    Prize = PrizeType.Diamonds,
                    Oportunity = 30
                }, new ChestOpportunity()
                {
                    Id = 6,
                    ChestId = 1,
                    Count = 1,
                    Prize = PrizeType.CharacterQuality,
                    Oportunity = 27
                }, new ChestOpportunity()
                {
                    Id = 7,
                    ChestId = 1,
                    Count = 1,
                    Prize = PrizeType.SpecialCharacter,
                    Oportunity = 3
                }
            };
        }

        public static List<CharacterOfBox> GetSpecCharacterOfBoxes()
        {
            return new List<CharacterOfBox>()
            {
                new CharacterOfBox()
                {
                    Id = 1,
                    ChestId = 1,
                    CharacterId = 4,
                    Oportunity = 1
                }
            };
        }

        public static List<CharacterQualityOfBox> GetCharacterQualityOfBoxes()
        {
            return new List<CharacterQualityOfBox>()
            {
                new CharacterQualityOfBox()
                {
                      ChestId = 1,
                      Id = 1,
                      Opportunity = 30,
                      Quality = CharacterQuality.Ordinary
                },
                new CharacterQualityOfBox()
                {
                    ChestId = 1,
                    Id = 2,
                    Opportunity = 10,
                    Quality = CharacterQuality.Powerful
                }
            };
        }
    }
}

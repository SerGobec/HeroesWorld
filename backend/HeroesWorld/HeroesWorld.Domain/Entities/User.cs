using HeroesWorld.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public string? TelegramId { get; set; }
        public int Carma { get; set; }
        public long Coins { get; set; }
        public long Diamonds { get; set; }
        public long Expirience { get; set; }
    }
}

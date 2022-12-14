using HeroesWorld.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Domain.Entities
{
    public class Prize
    {
        public PrizeType Type { get; set; }
        public string Name { get; set; }
        public long Count { get; set; }
        public string? Base64 { get; set; }
        public CharacterQuality Quality { get; set; }
    }
}

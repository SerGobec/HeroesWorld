using HeroesWorld.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Domain.Entities
{
    public class ChestOpportunity : BaseEntity
    {
        public PrizeType PrizeType { get; set; }
        public long Count { get; set; }
        public int Oportunity { get; set; }
        public long ChestId { get; set; }
        public Chest Chest { get; set; }
    }
}

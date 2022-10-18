using HeroesWorld.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Domain.Entities
{
    public class CharacterQualityOfBox : BaseEntity
    {

        public CharacterQuality Quality { get; set; }
        public int Opportunity { get; set; }
        public long ChestId { get; set; }
        Chest Chest { get; set; }
        
    }
}

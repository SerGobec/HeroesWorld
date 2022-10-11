using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Domain.Entities
{
    public class CharacterOfBox : BaseEntity
    {
        public int Oportunity { get; set; }
        public long CharacterId { get; set; }
        Character Character { get; set; }
    }
}

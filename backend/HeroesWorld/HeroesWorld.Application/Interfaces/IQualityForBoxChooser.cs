using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Application.Interfaces
{
    public interface ICharacterQualityForBoxChooser
    {
        public CharacterQuality ChooserCharacterQualityForBox(Chest box); 
    }
}

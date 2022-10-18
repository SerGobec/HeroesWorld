using HeroesWorld.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Application.Interfaces
{
    public interface ISpecialCharacterChooser
    {
        public CharacterOfBox GetSpecialCharacterFromBox(Chest box); 
    }
}

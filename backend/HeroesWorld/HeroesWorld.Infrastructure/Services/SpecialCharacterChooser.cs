using HeroesWorld.Application.Interfaces;
using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Repositories;

namespace HeroesWorld.Infrastructure.Services
{
    public class SpecialCharacterChooser : ISpecialCharacterChooser
    {
        ISpecialCharactersFBRepository _specialCharacters;
        public SpecialCharacterChooser(ISpecialCharactersFBRepository specialCharacters)
        {
            this._specialCharacters = specialCharacters;
        }
        public CharacterOfBox GetSpecialCharacterFromBox(Chest box)
        {
            var characters = this._specialCharacters.Find(el => el.ChestId == box.Id).ToList();

            int sumOfQuality = characters.Sum(el => el.Oportunity);
            Random rnd = new Random();
            int randomValue = rnd.Next(sumOfQuality);

            int CheckSum = 0;
            foreach (CharacterOfBox hero in characters)
            {
                CheckSum += hero.Oportunity;
                if (CheckSum >= randomValue) return hero;
            }
            return null;
        }
    }
}

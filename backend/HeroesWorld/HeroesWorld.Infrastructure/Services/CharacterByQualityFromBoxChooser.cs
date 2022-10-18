using HeroesWorld.Application.Interfaces;
using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Enums;
using HeroesWorld.Domain.Repositories;

namespace HeroesWorld.Infrastructure.Services
{
    public class CharacterByQualityFromBoxChooser : ICharacterByQualityFromBoxChooser
    {
        ICharacterQualityForBoxChooser _qulityChooser;
        ICharacterRepository _characters;
        public CharacterByQualityFromBoxChooser(ICharacterQualityForBoxChooser qulityChooser, ICharacterRepository characters)
        {
            this._qulityChooser = qulityChooser;
            this._characters = characters;
        }
        public Character GetRandomCharacterByQualityForBox(Chest chest)
        {
            CharacterQuality quality = _qulityChooser.ChooserCharacterQualityForBox(chest);
            var characters = _characters.Find(el => el.Quality == quality).ToList();
            if(characters != null)
            {
                int sumOfQuality = characters.Sum(el => el.ChanceOfDropping);
                Random rnd = new Random();
                int randomValue = rnd.Next(sumOfQuality);

                int CheckSum = 0;
                foreach (Character hero in characters)
                {
                    CheckSum += hero.ChanceOfDropping;
                    if (CheckSum >= randomValue) return hero;
                }
            }
            return null;
        }
    }
}

using HeroesWorld.Domain.Entities;

namespace HeroesWorld.Application.Interfaces
{
    public interface ICharacterByQualityFromBoxChooser
    {
        public Character GetRandomCharacterByQualityForBox(Chest chest);
    }
}

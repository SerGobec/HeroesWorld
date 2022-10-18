using HeroesWorld.Application.Interfaces;
using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Enums;
using HeroesWorld.Domain.Repositories;

namespace HeroesWorld.Infrastructure.Services
{
    public class BoxOpenerService : IBoxOpener
    {
        IChestOpportunitiesRepository _opportunities;
        IOpportunityChooser _chooser;
        ICharacterByQualityFromBoxChooser _chooserByQuality;
        IBoxesRepository _boxes;
        ISpecialCharacterChooser _specialCharacterChooser;
        ICharacterRepository _characters;
        public BoxOpenerService(IChestOpportunitiesRepository opportunitiesRepository,
                                IOpportunityChooser chooser,
                                ICharacterByQualityFromBoxChooser chooserByQuality,
                                IBoxesRepository boxes,
                                ISpecialCharacterChooser specialCharacterChooser,
                                ICharacterRepository characters)
        {
            this._opportunities = opportunitiesRepository;
            this._chooser = chooser;
            this._chooserByQuality = chooserByQuality;
            this._boxes = boxes;
            this._specialCharacterChooser = specialCharacterChooser;
            this._characters = characters;
        }
        public Prize OpenChest(Chest chest)
        {
            ChestOpportunity chosenPrize = _chooser.ChooseOneOpportunity(_opportunities.Find(el => el.ChestId == chest.Id));

            switch (chosenPrize.PrizeType)
            {
                case PrizeType.Coins:
                return new Prize()
                {
                    Name = "Coints",
                    Count = chosenPrize.Count,
                    Base64 = "",
                    Type = PrizeType.Coins
                };
                case PrizeType.Diamonds:
                return new Prize()
                {
                    Name = "Diamonds",
                    Count = chosenPrize.Count,
                    Base64 = String.Empty,
                    Type = PrizeType.Diamonds
                };
                case PrizeType.CharacterQuality:
                    Character hero = _chooserByQuality.GetRandomCharacterByQualityForBox(chest);
                    return new Prize()
                    {
                        Name = hero.Name,
                        Count = 1,
                        Base64 = hero.PhotoBase64,
                        Type = PrizeType.CharacterQuality,
                        Quality = hero.Quality
                    };
                    
                case PrizeType.SpecialCharacter:
                    CharacterOfBox specialHero = _specialCharacterChooser.GetSpecialCharacterFromBox(chest);
                    Character? character = this._characters.FirstOrDefault(el => el.Id == specialHero.CharacterId);
                    if(character != null)
                    {
                        return new Prize()
                        {
                            Count = 1,
                            Name = character.Name,
                            Quality = character.Quality,
                            Type = PrizeType.SpecialCharacter,
                            Base64 = character.PhotoBase64
                        };
                    }
                    break;
            }
            return null;
        }

        public Prize OpenChestById(long ChestId)
        {
            Chest box = this._boxes.GetById(ChestId);
            return this.OpenChest(box);
        }
    }
}

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
        public BoxOpenerService(IChestOpportunitiesRepository opportunitiesRepository, IOpportunityChooser chooser, ICharacterByQualityFromBoxChooser chooserByQuality, IBoxesRepository boxes)
        {
            this._opportunities = opportunitiesRepository;
            _chooser = chooser;
            this._chooserByQuality = chooserByQuality;
            this._boxes = boxes;
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
                    Base64 = ""
                };
                case PrizeType.Diamonds:
                return new Prize()
                {
                    Name = "Diamonds",
                    Count = chosenPrize.Count,
                    Base64 = String.Empty
                };
                case PrizeType.CharacterQuality:
                    Character hero = _chooserByQuality.GetRandomCharacterByQualityForBox(chest);
                    return new Prize()
                    {
                        Name = hero.Name,
                        Count = 1,
                        Base64 = hero.PhotoBase64
                    };
                 // TODO Add also for special characters
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

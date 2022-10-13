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
        IChooserByQuality _chooserByQuality;
        public BoxOpenerService(IChestOpportunitiesRepository opportunitiesRepository, IOpportunityChooser chooser, IChooserByQuality chooserByQuality)
        {
            this._opportunities = opportunitiesRepository;
            _chooser = chooser;
            this._chooserByQuality = chooserByQuality;
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
                    
            }
            return null;
        }
    }
}

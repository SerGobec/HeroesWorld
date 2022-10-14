using HeroesWorld.Application.Interfaces;
using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Enums;
using HeroesWorld.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Infrastructure.Services
{
    public class CharacterQualityForBoxChooserService : ICharacterQualityForBoxChooser
    {
        ICharactersQualitiesOfBoxRepository _qualities;
        public CharacterQualityForBoxChooserService(ICharactersQualitiesOfBoxRepository qualities)
        {
            this._qualities = qualities;
        }
        public CharacterQuality ChooserCharacterQualityForBox(Chest box)
        {
            var qualities = this._qualities.Find(el => el.ChestId == box.Id);
            int sumOfQuality = qualities.Sum(el => el.Opportunity);
            Random rnd = new Random();
            int randomValue = rnd.Next(sumOfQuality);

            int CheckSum = 0;
            foreach (CharacterQualityOfBox quality in qualities)
            {
                CheckSum += quality.Opportunity;
                if (CheckSum >= randomValue) return quality.Quality;
            }

            return CharacterQuality.Ordinary;
        }
    }
}

using HeroesWorld.Application.Interfaces;
using HeroesWorld.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Infrastructure.Services
{
    public class OpportunityChooserService : IOpportunityChooser
    {
        public ChestOpportunity ChooseOneOpportunity(IEnumerable<ChestOpportunity> opportunities)
        {
            int sumOfOpport = opportunities.Sum(el => el.Oportunity);
            Random rnd = new Random();
            int randomValue = rnd.Next(sumOfOpport);

            int CheckSum = 0;
            foreach (ChestOpportunity opportunity in opportunities) {
                CheckSum += opportunity.Oportunity;
                if(CheckSum >= randomValue) return opportunity;
            }
            return null;
        }
    }
}

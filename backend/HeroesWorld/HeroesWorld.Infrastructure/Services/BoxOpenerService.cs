using HeroesWorld.Application.Interfaces;
using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Infrastructure.Services
{
    public class BoxOpenerService : IBoxOpener
    {
        public BoxOpenerService(){

        }
        public Prize OpenChest(Chest chest)
        {
            throw new NotImplementedException();
        }
    }
}

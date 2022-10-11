﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Domain.Entities
{
    public class Chest : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Base64 { get; set; }
        public List<ChestOportunity> ChestOportunities { get; set; }
        public Chest()
        {
            this.ChestOportunities = new List<ChestOportunity>();
        }
    }
}
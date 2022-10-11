using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Application.Authentification.Commands.Registration
{
    public class NewUserDataModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
    }
}

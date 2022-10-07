using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HeroesWorld.API.Controllers
{
    public class ControllerBaseWithMediatR : ControllerBase
    {
        protected IMediator _mediatR;
        public ControllerBaseWithMediatR(IMediator mediatR)
        {
            this._mediatR = mediatR;
        }
    }
}

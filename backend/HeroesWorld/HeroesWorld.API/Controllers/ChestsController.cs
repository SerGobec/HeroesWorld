using HeroesWorld.Application.Chests.Commands.OpenBox;
using HeroesWorld.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HeroesWorld.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ChestsController : ControllerBaseWithMediatR
    {
        public ChestsController(IMediator mediatR) : base(mediatR)
        {
        }

        [HttpPost]
        [Route("openbox")]
        public async Task<ActionResult<Prize>> OpenBox([FromBody] long Id)
        {
            return await this._mediatR.Send(new OpenChestCommand(Id));
        }
    }
}

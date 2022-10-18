using HeroesWorld.Application.Interfaces;
using HeroesWorld.Domain.Entities;
using MediatR;

namespace HeroesWorld.Application.Chests.Commands.OpenBox
{
    public class OpenChestCommand : IRequest<Prize>
    {
        public long Id { get; }

        public OpenChestCommand(long Id)
        {
            this.Id = Id;
        }
    }

    public class OpenBoxHandler : IRequestHandler<OpenChestCommand, Prize>
    {
        IBoxOpener _opener;
        public OpenBoxHandler(IBoxOpener opener)
        {
            this._opener = opener;
        }
        public async Task<Prize> Handle(OpenChestCommand request, CancellationToken cancellationToken)
        {
            Prize prize = _opener.OpenChestById(request.Id);
            if (prize != null) return prize;
            throw new Exception("Can`t open box");
        }
    }
}

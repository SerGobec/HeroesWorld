using HeroesWorld.Domain.Repositories;
using MediatR;
using HeroesWorld.Domain.Enums;

namespace HeroesWorld.Application.Authentification.Commands.Registration
{
    public class RegistrateNewUserCommand : IRequest
    {
        public NewUserDataModel data { get; }
        public RegistrateNewUserCommand(NewUserDataModel data)
        {
            this.data = data;
        }
    }

    public class RegistrateNewUserHandler : IRequestHandler<RegistrateNewUserCommand>
    {
        private IUserRepository _users;
        public RegistrateNewUserHandler(IUserRepository users)
        {
            this._users = users;
        }

        public async Task<Unit> Handle(RegistrateNewUserCommand request, CancellationToken cancellationToken)
        {
            if (_users.Find(el => el.Username == request.data.Nickname || el.Email == request.data.Email).Count() == 0)
            {
                this._users.Add(new HeroesWorld.Domain.Entities.User()
                {
                    Username = request.data.Nickname,
                    Email = request.data.Email,
                    Coints = 10000,
                    Diamonds = 10,
                    Expirience = 0,
                    Password = request.data.Password,
                    Role = UserRole.Player,
                    TelegramId = null
                });
                await this._users.SaveChanges();
            }
            else throw new Exception("User already exist");
            return Unit.Value;
        }
    }


}

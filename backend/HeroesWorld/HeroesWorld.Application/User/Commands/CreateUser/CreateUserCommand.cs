using HeroesWorld.Domain.Repositories;
using MediatR;

namespace HeroesWorld.Application.User.Commands.CreateUser
{
    public class CreateUserCommand : IRequest
    {
        public string Username { get; set; }
    }

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserRepository _repository;

        public CreateUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            _repository.Add(new Domain.Entities.User()
            {
                Coints = 0,
                Email = "asd",
                Diamonds = 0,
                Expirience = 0,
                Password = "sd",
                Role = Domain.Enums.UserRole.Player,
                TelegramId = null,
                Username = request.Username
            });
            await _repository.SaveChanges();
            return Unit.Value;
        }
    }
}

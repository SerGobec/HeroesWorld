using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Repositories;
using MediatR;

namespace HeroesWorld.Application.Authentification.Commands.Login
{
    public class LoginCommand : IRequest<User>
    {
        public LogInModel model { get; }
        public LoginCommand(LogInModel model)
        {
            this.model = model;
        }
    }

    public class LoginHandler : IRequestHandler<LoginCommand, User>
    {
        private IUserRepository _users;

        public LoginHandler(IUserRepository users)
        {
            _users = users;
        }

        public async Task<User> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            User? user = _users.FirstOrDefault(el => el.Email == request.model.Email && el.Password == request.model
            .Password);
            if(user != null) return user;
            throw new Exception("Wrong password or email");
        }
    }
}

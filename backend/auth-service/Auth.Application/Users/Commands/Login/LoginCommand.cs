using MediatR;

namespace Auth.Application.Users.Commands.Login;

public record LoginCommand(string Email, string Password) : IRequest<>


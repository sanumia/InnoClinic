using MediatR;

namespace Auth.Application.Users.Commands.Register;

public record RegisterCommand(string Email, string Password, string FullName) : IRequest<Guid>;



using Domain.Core.Premitives;
using MediatR;

namespace Application.Core.Abstructions.Messaging
{
    public interface ICommand<out TResponse> : IRequest<TResponse>;
}

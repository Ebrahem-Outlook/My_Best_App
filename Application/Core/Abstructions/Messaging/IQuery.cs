using Domain.Core.Premitives;
using MediatR;

namespace Application.Core.Abstructions.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>;
}

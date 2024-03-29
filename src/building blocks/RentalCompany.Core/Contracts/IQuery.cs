using MediatR;

namespace RentalCompany.Core.Contracts
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}

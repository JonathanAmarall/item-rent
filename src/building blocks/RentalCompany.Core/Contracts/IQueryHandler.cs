using MediatR;

namespace RentalCompany.Core.Contracts
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
      where TQuery : IQuery<TResponse>
    {
    }
}

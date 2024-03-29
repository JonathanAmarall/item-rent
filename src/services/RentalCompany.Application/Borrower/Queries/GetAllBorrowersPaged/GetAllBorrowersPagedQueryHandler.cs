using RentalCompany.Core.Contracts;
using RentalCompany.Core.DTOs;
using RentalCompany.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCompany.Application.Borrower.Queries.GetAllBorrowersPaged
{
    public class GetAllBorrowersPagedQueryHandler : IQueryHandler<GetAllBorrowersPagedQuery, PagedList<Domain.Entities.Borrower>>
    {
        private readonly IBorrowerRepository _borrowerRepository;

        public GetAllBorrowersPagedQueryHandler(IBorrowerRepository borrowerRepository)
            => _borrowerRepository = borrowerRepository;

        public async Task<PagedList<Domain.Entities.Borrower>> Handle(GetAllBorrowersPagedQuery request, CancellationToken cancellationToken)
            => await _borrowerRepository.GetAllPagedAsync(
               request.GlobalFilter,
               request.SortOrder,
               request.SortField,
               request.PageNumber,
               request.PageSize);
    }
}

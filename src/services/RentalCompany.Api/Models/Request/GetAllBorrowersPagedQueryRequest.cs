using RentalCompany.Application.Borrower.Queries.GetAllBorrowersPaged;
using RentalCompany.Core.Models;

namespace RentalCompany.Api.Models.Request
{
    public record GetAllBorrowersPagedQueryRequest : PagedListQueryBase
    {
        public GetAllBorrowersPagedQuery BuildQuery()
        {
            return new GetAllBorrowersPagedQuery
            {
                GlobalFilter = GlobalFilter,
                PageNumber = PageNumber,
                PageSize = PageSize,
                SortField = SortField,
                SortOrder = SortOrder
            };
        }
    }
}

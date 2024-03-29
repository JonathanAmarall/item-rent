using RentalCompany.Core.Contracts;
using RentalCompany.Core.DTOs;
using RentalCompany.Core.Models;

namespace RentalCompany.Application.Borrower.Queries.GetAllBorrowersPaged
{
    public record GetAllBorrowersPagedQuery : PagedListQueryBase, IQuery<PagedList<Domain.Entities.Borrower>>;
}

using RentalCompany.Core.Models;
using RentalCompany.Domain.Entities;

namespace RentalCompany.Api.Models.Request
{
    public record GetAllPagedCollectionItemQueryRequest : PagedListQueryBase
    {
        public ECollectionStatus? Status { get; set; }
        public EType? Type { get; set; }
    }
}

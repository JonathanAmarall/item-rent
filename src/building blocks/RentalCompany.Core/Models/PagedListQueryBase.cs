namespace RentalCompany.Core.Models
{
    public abstract record PagedListQueryBase
    {
        public string? GlobalFilter { get; set; }
        public string? SortOrder { get; set; }
        public string? SortField { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 5;
    }
}

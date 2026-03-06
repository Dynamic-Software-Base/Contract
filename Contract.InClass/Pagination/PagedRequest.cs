namespace Contract.InClass.Pagination;

public class PagedRequest
{
    private const int MaxPageSize = 50;
    private int _pageSize = 10;

    public int Page { get; init; } = 1;
    public int PageSize
    {
        get => _pageSize;
        init => _pageSize = value > MaxPageSize ? MaxPageSize : value;
    }
    public string? SortBy { get; init; }
    public bool Descending { get; init; }
}
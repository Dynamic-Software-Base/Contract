namespace Contract.InClass.ApiContract;

public sealed class ApiError
{
    public string Code { get; init; } = string.Empty;
    public string Message { get; init; } = string.Empty;
    public ApiError Type{ get; init; }
    
    public string? PropertyName { get; init; }
}
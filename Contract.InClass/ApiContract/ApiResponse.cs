namespace Contract.InClass.ApiContract;

public class ApiResponse<T>
{
    public bool IsSuccess { get; init; }
    public T? Data { get; init; }
    public ApiError[]? Errors { get; init; }
    
    public static ApiResponse<T> Success(T data) =>
        new() { IsSuccess = true, Data = data };

    public static ApiResponse<T> Failure(IEnumerable<ApiError> errors) =>
        new() { IsSuccess = false, Errors = errors.ToArray() };
}

public sealed class ApiResponse : ApiResponse<object?>
{
    public static ApiResponse Ok() =>
        new() { IsSuccess = true };
}
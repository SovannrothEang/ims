namespace api.Application.DTOs.Response;

public class SuccessResponse<T>(
    T data,
    string message
) : ApiReponseDto<T>(true, message)
{
    public T? Data { get; set; } = data;
}

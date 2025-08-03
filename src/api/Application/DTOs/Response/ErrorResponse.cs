namespace api.Application.DTOs.Response;

public class ErrorResponse(
    string message,
    string? error
) : ApiReponseDto<string>(false, message)
{
    public string? Error { get; set; } = error;
}

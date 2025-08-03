namespace api.Application.DTOs.Response;

public class ApiReponseDto<T> (
    bool success,
    string message)
{
    public bool Success { get; set; } = success;
    public string Message { get; set; } = message;
}
namespace api.Application.DTOs.Response;

public class ApiReponseDto<T> (
    bool success,
    T? data,
    string? message,
    string? error)
{
    public bool Success { get; set; } = success;
    public T? Data { get; set; } = data;
    public string? Message { get; set; } = message;
    public string? Error { get; set; } = error;
}
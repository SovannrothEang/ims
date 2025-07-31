namespace api.Application.DTOs.Response;

public class SuccessResponse<T>(
    T data,
    string? message
) : ApiReponseDto<T>(true, data, message, null) {}

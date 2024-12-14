namespace DoctorAppointmentWeb.Api.Exceptions;

/// <summary>
/// Исключение для ошибок валидации.
/// </summary>
public class ValidationException : Exception
{
    public ValidationException(string fieldName, string errorMessage) 
        : base($"Возникла проблема валидации на поле '{fieldName}': {errorMessage}") { }
}


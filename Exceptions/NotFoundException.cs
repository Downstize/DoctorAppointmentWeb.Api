namespace DoctorAppointmentWeb.Api.Exceptions;

/// <summary>
/// Исключение для случая, когда ресурс не найден.
/// </summary>
public class NotFoundException : Exception
{
    public NotFoundException(string resourceName, string key) 
        : base($"Ресурс '{resourceName}' с данным ключём '{key}' не был найден.") { }
}
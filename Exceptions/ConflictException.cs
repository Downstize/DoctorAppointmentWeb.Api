namespace DoctorAppointmentWeb.Api.Exceptions;

/// <summary>
/// Исключение для случаев конфликта данных.
/// </summary>
public class ConflictException : Exception
{
    public ConflictException(string message) : base($"Конфликт: {message}") { }
}
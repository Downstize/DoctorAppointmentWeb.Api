namespace DoctorAppointmentWeb.Api.Exceptions;

/// <summary>
/// Исключение для случая, когда доступ запрещен.
/// </summary>
public class UnauthorizedAccessException : Exception
{
    public UnauthorizedAccessException(string message = "Доступ запрещён.") : base(message) { }
}
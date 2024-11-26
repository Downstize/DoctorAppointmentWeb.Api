namespace DoctorAppointmentWeb.Api.Exceptions;

/// <summary>
/// Исключение для случая, когда доступ запрещен.
/// </summary>
public class UnauthorizedAccessExceptions : Exception
{
    public UnauthorizedAccessExceptions(string message = "Доступ запрещён.") : base(message) { }
}
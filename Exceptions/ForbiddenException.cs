namespace DoctorAppointmentWeb.Api.Exceptions;

/// <summary>
/// Исключение для запрещенных действий.
/// </summary>
public class ForbiddenException : Exception
{
    public ForbiddenException(string message = "У вас нет прав для доступа к данному действию.") : base(message) { }
}
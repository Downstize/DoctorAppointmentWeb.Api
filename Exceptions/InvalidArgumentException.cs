namespace DoctorAppointmentWeb.Api.Exceptions;

/// <summary>
/// Исключение выбрасываемое при передаче некорректных аргументов
/// </summary>
public class InvalidArgumentException : Exception
{
    public InvalidArgumentException(string message) : base($"Некорректный аргумент: {message}") { }
}
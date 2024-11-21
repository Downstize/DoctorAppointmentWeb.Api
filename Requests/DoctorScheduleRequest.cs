using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoctorAppointmentWebApi.DTOs;

public record DoctorScheduleRequest
{
    [Required(ErrorMessage = "Идентификатор расписания обязателен.")]
    public Guid ScheduleId { get; set; }

    [Required(ErrorMessage = "Идентификатор врача обязателен.")]
    public Guid DoctorId { get; set; }

    [Required(ErrorMessage = "Время начала доступности обязательно.")]
    public TimeSpan AvailableFrom { get; set; }

    [Required(ErrorMessage = "Время окончания доступности обязательно.")]
    public TimeSpan AvailableTo { get; set; }

    [Required(ErrorMessage = "День недели обязателен.")]
    [StringLength(20, ErrorMessage = "Длина названия дня не может превышать 20 символов.")]
    public string DayOfWeek { get; set; }
}
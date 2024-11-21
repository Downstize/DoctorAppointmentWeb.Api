using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoctorAppointmentWebApi.DTOs;

public record SpecializationRequest
{
    [Required(ErrorMessage = "Идентификатор специализации обязателен.")]
    public Guid SpecializationId { get; set; }

    [StringLength(100, ErrorMessage = "Длина названия специализации не может превышать 100 символов.")]
    public string? SpecializationName { get; set; }
}
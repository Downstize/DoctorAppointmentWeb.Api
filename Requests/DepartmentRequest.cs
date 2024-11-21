using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoctorAppointmentWebApi.DTOs;

public record DepartmentRequest
{
    [Required(ErrorMessage = "Идентификатор департамента обязателен.")]
    public Guid DepartmentId { get; set; }

    [Required(ErrorMessage = "Имя отдела обязательно.")]
    [StringLength(100, ErrorMessage = "Длина имени не может превышать 100 символов.")]
    public string Name { get; set; }

    [StringLength(200, ErrorMessage = "Длина местоположения не может превышать 200 символов.")]
    public string Location { get; set; }
}
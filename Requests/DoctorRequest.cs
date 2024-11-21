using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoctorAppointmentWebApi.DTOs;

public record DoctorRequest
{
    [Required(ErrorMessage = "Идентификатор доктора обязателен.")]
    public Guid DoctorId { get; set; }

    [Required(ErrorMessage = "Имя врача обязательно.")]
    [StringLength(50, ErrorMessage = "Длина имени не может превышать 50 символов.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Фамилия врача обязательна.")]
    [StringLength(50, ErrorMessage = "Длина фамилии не может превышать 50 символов.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Идентификатор специализации обязателен.")]
    public Guid SpecializationId { get; set; }

    [Required(ErrorMessage = "Идентификатор отдела обязателен.")]
    public Guid DepartmentId { get; set; }

    [Phone(ErrorMessage = "Некорректный номер телефона.")]
    [StringLength(20, ErrorMessage = "Длина номера телефона не может превышать 20 символов.")]
    public string PhoneNumber { get; set; }

    [EmailAddress(ErrorMessage = "Некорректный email.")]
    public string Email { get; set; }

    [StringLength(10, ErrorMessage = "Длина номера комнаты не может превышать 10 символов.")]
    public string RoomNumber { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoctorAppointmentWebApi.DTOs;

public record PatientRequest
{
    [Required(ErrorMessage = "Идентификатор пациента обязателен.")]
    public Guid PatientID { get; set; }

    [Required(ErrorMessage = "Имя пациента обязательно.")]
    [StringLength(50, ErrorMessage = "Длина имени не может превышать 50 символов.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Фамилия пациента обязательна.")]
    [StringLength(50, ErrorMessage = "Длина фамилии не может превышать 50 символов.")]
    public string LastName { get; set; }

    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(10, ErrorMessage = "Длина пола не может превышать 10 символов.")]
    public string Gender { get; set; }

    [Phone(ErrorMessage = "Некорректный номер телефона.")]
    [StringLength(20, ErrorMessage = "Длина номера телефона не может превышать 20 символов.")]
    public string PhoneNumber { get; set; }

    [EmailAddress(ErrorMessage = "Некорректный email.")]
    public string Email { get; set; }

    [StringLength(200, ErrorMessage = "Длина адреса не может превышать 200 символов.")]
    public string Address { get; set; }

    [StringLength(50, ErrorMessage = "Длина страхового номера не может превышать 50 символов.")]
    public string InsuranceNumber { get; set; }
}

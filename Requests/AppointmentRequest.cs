using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentWebApi.DTOs
{
    public record AppointmentRequest
    {
        [Required(ErrorMessage = "Идентификатор записи обязателен.")]
        public Guid AppointmentId { get; set; }

        [Required(ErrorMessage = "Идентификатор пациента обязателен.")]
        public Guid PatientId { get; set; }

        [Required(ErrorMessage = "Идентификатор врача обязателен.")]
        public Guid DoctorId { get; set; }

        [Required(ErrorMessage = "Дата и время записи обязательны.")]
        public DateTime AppointmentDateTime { get; set; }

        [Required(ErrorMessage = "Статус записи обязателен.")]
        [StringLength(50, ErrorMessage = "Длина статуса не может превышать 50 символов.")]
        public string Status { get; set; }

        [StringLength(500, ErrorMessage = "Длина заметок не может превышать 500 символов.")]
        public string Notes { get; set; }
    }
}
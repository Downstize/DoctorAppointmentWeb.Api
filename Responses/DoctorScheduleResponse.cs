namespace DoctorAppointmentWeb.Api.Responses;

public record DoctorScheduleResponse
{
    public Guid ScheduleId { get; set; }
    
    public Guid DoctorId { get; set; }

    public TimeSpan AvailableFrom { get; set; }

    public TimeSpan AvailableTo { get; set; }
    
    public string DayOfWeek { get; set; }
}
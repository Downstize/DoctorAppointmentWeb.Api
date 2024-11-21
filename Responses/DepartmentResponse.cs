namespace DoctorAppointmentWeb.Api.Responses;

public record DepartmentResponse
{
    public Guid DepartmentId { get; set; }
    
    public string Name { get; set; }
    
    public string Location { get; set; }
}
namespace DoctorAppointmentWeb.Api.Responses;

public record DoctorResponse
{
    public Guid DoctorId { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public Guid SpecializationId { get; set; }

    public Guid DepartmentId { get; set; }
    
    public string PhoneNumber { get; set; }

    public string Email { get; set; }
    
    public string RoomNumber { get; set; }
}
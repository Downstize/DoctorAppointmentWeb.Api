namespace DoctorAppointmentWeb.Api.Responses;

public record SpecializationResponse
{
    public Guid SpecializationId { get; set; }
    
    public string? SpecializationName { get; set; }
}
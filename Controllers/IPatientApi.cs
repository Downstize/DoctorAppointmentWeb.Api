using DoctorAppointmentWeb.Api.Responses;
using DoctorAppointmentWebApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DoctorAppointmentWeb.Api.Controllers;

/// <summary>
/// Контракт для работы с пациентами.
/// </summary>
public interface IPatientApi
{
    [HttpGet]
    [SwaggerOperation(Summary = "Получить список всех пациентов", Description = "Возвращает список всех записей пациентов.")]
    [SwaggerResponse(200, "Список пациентов успешно возвращен", typeof(IEnumerable<PatientResponse>))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<IEnumerable<PatientResponse>>> GetPatients();

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Получить пациента по ID", Description = "Возвращает информацию о конкретном пациенте.")]
    [SwaggerResponse(200, "Пациент найден", typeof(PatientResponse))]
    [SwaggerResponse(404, "Пациент не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<PatientResponse>> GetPatientById(Guid id);

    [HttpPost]
    [SwaggerOperation(Summary = "Создать нового пациента", Description = "Создает нового пациента и возвращает созданный объект.")]
    [SwaggerResponse(201, "Пациент успешно создан", typeof(PatientResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<PatientResponse>> CreatePatient([FromBody] PatientRequest request);

    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Обновить данные пациента", Description = "Обновляет информацию о существующем пациенте.")]
    [SwaggerResponse(200, "Данные пациента успешно обновлены", typeof(PatientResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(404, "Пациент не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> UpdatePatient(Guid id, [FromBody] PatientRequest request);

    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Удалить пациента", Description = "Удаляет существующего пациента.")]
    [SwaggerResponse(200, "Пациент успешно удален", typeof(string))]
    [SwaggerResponse(404, "Пациент не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> DeletePatient(Guid id);
}
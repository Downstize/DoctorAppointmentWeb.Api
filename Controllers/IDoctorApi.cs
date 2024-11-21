using DoctorAppointmentWeb.Api.Responses;
using DoctorAppointmentWebApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DoctorAppointmentWeb.Api.Controllers;

/// <summary>
/// Контракт для работы с врачами.
/// </summary>
public interface IDoctorApi
{
    [HttpGet]
    [SwaggerOperation(Summary = "Получить список всех врачей", Description = "Возвращает список всех записей врачей.")]
    [SwaggerResponse(200, "Список врачей успешно возвращен", typeof(IEnumerable<DoctorResponse>))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<IEnumerable<DoctorResponse>>> GetDoctors();

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Получить врача по ID", Description = "Возвращает информацию о конкретном враче.")]
    [SwaggerResponse(200, "Врач найден", typeof(DoctorResponse))]
    [SwaggerResponse(404, "Врач не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<DoctorResponse>> GetDoctorById(Guid id);

    [HttpPost]
    [SwaggerOperation(Summary = "Создать нового врача", Description = "Создает нового врача и возвращает созданный объект.")]
    [SwaggerResponse(201, "Врач успешно создан", typeof(DoctorResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<DoctorResponse>> CreateDoctor([FromBody] DoctorRequest request);

    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Обновить данные врача", Description = "Обновляет информацию о существующем враче.")]
    [SwaggerResponse(200, "Данные врача успешно обновлены", typeof(DoctorResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(404, "Врач не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> UpdateDoctor(Guid id, [FromBody] DoctorRequest request);

    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Удалить врача", Description = "Удаляет существующего врача.")]
    [SwaggerResponse(200, "Врач успешно удален", typeof(string))]
    [SwaggerResponse(404, "Врач не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> DeleteDoctor(Guid id);
}
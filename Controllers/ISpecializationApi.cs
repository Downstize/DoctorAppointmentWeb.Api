using DoctorAppointmentWeb.Api.Responses;
using DoctorAppointmentWebApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DoctorAppointmentWeb.Api.Controllers;

/// <summary>
/// Контракт для работы со специализациями.
/// </summary>
public interface ISpecializationApi
{
    [HttpGet]
    [SwaggerOperation(Summary = "Получить список всех специализаций", Description = "Возвращает список всех записей специализаций.")]
    [SwaggerResponse(200, "Список специализаций успешно возвращен", typeof(IEnumerable<SpecializationResponse>))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<IEnumerable<SpecializationResponse>>> GetSpecializations();

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Получить специализацию по ID", Description = "Возвращает информацию о конкретной специализации.")]
    [SwaggerResponse(200, "Специализация найдена", typeof(SpecializationResponse))]
    [SwaggerResponse(404, "Специализация не найдена")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<SpecializationResponse>> GetSpecializationById(Guid id);

    [HttpPost]
    [SwaggerOperation(Summary = "Создать новую специализацию", Description = "Создает новую специализацию и возвращает созданный объект.")]
    [SwaggerResponse(201, "Специализация успешно создана", typeof(SpecializationResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<SpecializationResponse>> CreateSpecialization([FromBody] SpecializationRequest request);

    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Обновить специализацию", Description = "Обновляет информацию о существующей специализации.")]
    [SwaggerResponse(200, "Специализация успешно обновлена", typeof(SpecializationResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(404, "Специализация не найдена")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> UpdateSpecialization(Guid id, [FromBody] SpecializationRequest request);

    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Удалить специализацию", Description = "Удаляет существующую специализацию.")]
    [SwaggerResponse(200, "Специализация успешно удалена", typeof(string))]
    [SwaggerResponse(404, "Специализация не найдена")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> DeleteSpecialization(Guid id);
}
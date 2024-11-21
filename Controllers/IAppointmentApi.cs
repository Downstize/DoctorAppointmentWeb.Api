using DoctorAppointmentWeb.Api.Responses;
using DoctorAppointmentWebApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DoctorAppointmentWeb.Api.Controllers;

/// <summary>
/// Контракт для работы с приемами.
/// </summary>

public interface IAppointmentApi
{
    [HttpGet]
    [SwaggerOperation(Summary = "Получить список всех приемов", Description = "Возвращает список всех записей на прием.")]
    [SwaggerResponse(200, "Список приемов успешно возвращен", typeof(IEnumerable<AppointmentResponse>))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<IEnumerable<AppointmentResponse>>> GetAppointments();

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Получить прием по ID", Description = "Возвращает информацию о конкретной записи на прием.")]
    [SwaggerResponse(200, "Запись найдена", typeof(AppointmentResponse))]
    [SwaggerResponse(404, "Запись не найдена", typeof(string))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<AppointmentResponse>> GetAppointmentById(Guid id);

    [HttpPost]
    [SwaggerOperation(Summary = "Создать новую запись", Description = "Создает новую запись на прием и возвращает созданный объект.")]
    [SwaggerResponse(201, "Запись успешно создана", typeof(AppointmentResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных", typeof(AppointmentResponse))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<AppointmentResponse>> CreateAppointment([FromBody] AppointmentRequest request);

    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Обновить запись", Description = "Обновляет информацию о существующей записи на прием.")]
    [SwaggerResponse(200, "Запись успешно обновлена", typeof(AppointmentResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(404, "Запись не найдена")]
    Task<IActionResult> UpdateAppointment(Guid id, [FromBody] AppointmentRequest request);

    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Удалить запись", Description = "Удаляет существующую запись на прием.")]
    [SwaggerResponse(200, "Запись успешно удалена", typeof(string))]
    [SwaggerResponse(404, "Запись не найдена", typeof(string))]
    Task<IActionResult> DeleteAppointment(Guid id);
}
using DoctorAppointmentWeb.Api.Responses;
using DoctorAppointmentWebApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DoctorAppointmentWeb.Api.Controllers;

/// <summary>
/// Контракт для работы с расписанием врачей.
/// </summary>
public interface IDoctorScheduleApi
{
    [HttpGet]
    [SwaggerOperation(Summary = "Получить список всех расписаний", Description = "Возвращает список всех записей расписаний врачей.")]
    [SwaggerResponse(200, "Список расписаний успешно возвращен", typeof(IEnumerable<DoctorScheduleResponse>))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<IEnumerable<DoctorScheduleResponse>>> GetSchedules();

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Получить расписание по ID", Description = "Возвращает информацию о конкретном расписании врача.")]
    [SwaggerResponse(200, "Расписание найдено", typeof(DoctorScheduleResponse))]
    [SwaggerResponse(404, "Расписание не найдено")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<DoctorScheduleResponse>> GetScheduleById(Guid id);

    [HttpPost]
    [SwaggerOperation(Summary = "Создать новое расписание", Description = "Создает новое расписание для врача и возвращает созданный объект.")]
    [SwaggerResponse(201, "Расписание успешно создано", typeof(DoctorScheduleResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<DoctorScheduleResponse>> CreateSchedule([FromBody] DoctorScheduleRequest request);

    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Обновить расписание", Description = "Обновляет информацию о существующем расписании.")]
    [SwaggerResponse(200, "Расписание успешно обновлено", typeof(DoctorScheduleResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(404, "Расписание не найдено")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> UpdateSchedule(Guid id, [FromBody] DoctorScheduleRequest request);

    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Удалить расписание", Description = "Удаляет существующее расписание врача.")]
    [SwaggerResponse(200, "Расписание успешно удалено", typeof(string))]
    [SwaggerResponse(404, "Расписание не найдено")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> DeleteSchedule(Guid id);
}
using DoctorAppointmentWeb.Api.Responses;
using DoctorAppointmentWebApi.DTOs;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DoctorAppointmentWeb.Api.Controllers;

/// <summary>
/// Контракт для работы с департаментами.
/// </summary>
public interface IDepartmentApi
{
    [HttpGet]
    [SwaggerOperation(Summary = "Получить список всех департаментов", Description = "Возвращает список всех записей департаментов.")]
    [SwaggerResponse(200, "Список департаментов успешно возвращен", typeof(IEnumerable<DepartmentResponse>))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<IEnumerable<DepartmentResponse>>> GetDepartments();

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Получить департамент по ID", Description = "Возвращает информацию о конкретном департаменте.")]
    [SwaggerResponse(200, "Департамент найден", typeof(DepartmentResponse))]
    [SwaggerResponse(404, "Департамент не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<DepartmentResponse>> GetDepartmentById(Guid id);

    [HttpPost]
    [SwaggerOperation(Summary = "Создать новый департамент", Description = "Создает новый департамент и возвращает созданный объект.")]
    [SwaggerResponse(201, "Департамент успешно создан", typeof(DepartmentResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<DepartmentResponse>> CreateDepartment([FromBody] DepartmentRequest request);

    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Обновить департамент", Description = "Обновляет информацию о существующем департаменте.")]
    [SwaggerResponse(200, "Департамент успешно обновлен", typeof(DepartmentResponse))]
    [SwaggerResponse(400, "Ошибка валидации данных")]
    [SwaggerResponse(404, "Департамент не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> UpdateDepartment(Guid id, [FromBody] DepartmentRequest request);

    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Удалить департамент", Description = "Удаляет существующий департамент.")]
    [SwaggerResponse(200, "Департамент успешно удален", typeof(string))]
    [SwaggerResponse(404, "Департамент не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> DeleteDepartment(Guid id);
}
using Microsoft.AspNetCore.Mvc;
using Notification.Notification.Repositories;
using Notification.Notification.UseCases;

namespace Notification.Notification.Controllers;

[ApiController]
[Route("notifications")]
public class NotificationController : ControllerBase
{
    private readonly NotificationRepository _repository;

    public NotificationController(NotificationRepository repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public IActionResult Create([FromBody] dynamic data)
    {
        try
        {
            var useCase = new CreateNotificationUseCase(_repository);

            var notification = useCase.Execute(
                (string)data.title,
                (string)data.description
            );

            return Ok(notification);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_repository.GetAll());
    }

    [HttpPatch("{id}/read")]
    public IActionResult MarkAsRead(Guid id)
    {
        var notification = _repository.GetById(id);

        if (notification == null)
            return NotFound();

        notification.MarkAsRead();

        return Ok(notification);
    }
}
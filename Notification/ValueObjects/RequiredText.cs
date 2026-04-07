using Notification.Notification.Entities;
using Notification.Notification.Repositories;
using Notification.Notification.ValueObjects;

namespace Notification.Notification.UseCases;

public class CreateNotificationUseCase
{
    private readonly NotificationRepository _repository;

    public CreateNotificationUseCase(NotificationRepository repository)
    {
        _repository = repository;
    }

    public Notification Execute(string title, string description)
    {
        var notification = new Notification(
            new RequiredText(title),
            new RequiredText(description)
        );

        _repository.Save(notification);

        return notification;
    }
}
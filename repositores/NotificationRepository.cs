using Notification.Notification.Entities;

namespace Notification.Notification.Repositories;

public class NotificationRepository
{
    private static List<Notification> _notifications = new();

    public void Save(Notification notification)
    {
        _notifications.Add(notification);
    }

    public List<Notification> GetAll()
    {
        return _notifications;
    }

    public Notification GetById(Guid id)
    {
        return _notifications.FirstOrDefault(n => n.Id == id);
    }
}
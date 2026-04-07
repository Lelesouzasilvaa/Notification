using Notification.Notification.ValueObjects;

namespace Notification.Notification.Entities;

public class Notification
{
    public Guid Id { get; private set; }
    public RequiredText Title { get; set; }
    public RequiredText Description { get; set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsRead { get; private set; }

    public Notification(RequiredText title, RequiredText description)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        CreatedAt = DateTime.Now;
        IsRead = false;
    }

    public void MarkAsRead()
    {
        IsRead = true;
    }
}

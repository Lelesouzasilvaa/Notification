using Notification.Notification.ValueObjects;

namespace Notification.Notification.Entities;

public class Notification
{
    public RequiredText Title { get; set; }
    public RequiredText Description { get; set; }

    public Notification(RequiredText title, RequiredText description)
    {
        Title = title; 
        Description = description;   
    }
}



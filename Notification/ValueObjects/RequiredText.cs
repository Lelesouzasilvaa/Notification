
namespace Notification.Notification.ValueObjects;

public class RequiredText
{
    public string Value { get; private set; }

    public RequiredText(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException("value");
        }

        Value = value;
    }
}

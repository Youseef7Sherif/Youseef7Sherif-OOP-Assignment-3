namespace RefactoringLab;

public class Notification
{
    private readonly IChannel _channel;
    private readonly bool _isUrgent;
    private readonly bool _isScheduled;
    private readonly DateTime _sendAt;

    public Notification(IChannel channel, bool isUrgent=false, bool isScheduled=false, DateTime sendAt=default)
    {
        _channel = channel;
        _isUrgent = isUrgent;
        _isScheduled = isScheduled;
        _sendAt = sendAt;
    }
    public void Send(string to, string message)
    {
         if(_isUrgent)
        message = $"[URGENT] {message}";
         if (_isScheduled)
            _channel.Schedule(to, message, _sendAt);
        else
            _channel.Send(to, message);
    }
}

public interface IChannel
{
    void Send(string to, string message);

    void Schedule(string to, string message, DateTime sendAt);
}


public class EmailNotification : IChannel
{
    public  void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
    public void Schedule(string to, string message, DateTime sendAt) =>
        Console.WriteLine($"[email scheduled {sendAt:g}] {to}: {message}");
}

public class SmsNotification : IChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
    public void Schedule(string to, string message, DateTime sendAt) =>
        Console.WriteLine($"[sms scheduled {sendAt:g}] {to}: {message}");
}
public class WhatsAppNotification : IChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[whatsapp] {to}: {message}");
    public void Schedule(string to, string message, DateTime sendAt) =>
        Console.WriteLine($"[whatsapp scheduled {sendAt:g}] {to}: {message}");
}
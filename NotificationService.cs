public class NotificationService
{
    public NotificationService(MessageReceiver receiver)
    {
        receiver.MessageReceived += OnMessageReceived;
    }

    private void OnMessageReceived(object sender, MessageReceivedEventArgs e)
    {
        // Handle the new message event here
        Console.WriteLine($"New message received from {e.Sender}: {e.Message}");
    }
}
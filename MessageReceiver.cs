public class MessageReceiver
{
    public event EventHandler<MessageReceivedEventArgs> MessageReceived;

    public void ReceiveMessage(string sender, string message)
    {
        OnMessageReceived(new MessageReceivedEventArgs(sender, message));
    }

    protected virtual void OnMessageReceived(MessageReceivedEventArgs e)
    {
        MessageReceived?.Invoke(this, e);
    }
}
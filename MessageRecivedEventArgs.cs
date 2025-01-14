public class MessageReceivedEventArgs : EventArgs
{
    public string Sender { get; set; }
    public string Message { get; set; }

    public MessageReceivedEventArgs(string sender, string message)
    {
        Sender = sender;
        Message = message;
    }
}
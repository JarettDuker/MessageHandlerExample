class Program
{
    static void Main(string[] args)
    {
        MessageReceiver receiver = new MessageReceiver();
        NotificationService notificationService = new NotificationService(receiver);

        receiver.ReceiveMessage("John", "Hello, how are you?");

        Console.ReadLine();
    }
}
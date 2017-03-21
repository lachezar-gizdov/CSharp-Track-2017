namespace Messages
{
    using Engine;

    public class StartUp
    {
        public static void Main()
        {
            Message message = new Message();
            message.Check(true);
        }
    }
}
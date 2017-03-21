namespace Messages.Engine
{
    using System;

    public class Message
    {
        public void Check(bool messagToVerify)
        {
            string messageToVerify = messagToVerify.ToString();

            Console.WriteLine(messageToVerify);
        }
    }
}
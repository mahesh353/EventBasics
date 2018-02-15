using System;

namespace EventBasics
{
    public class MessageService
    {
        public void OnVideoEncoded(object sender, EventArgs e)
        {
            Console.WriteLine("Message sent in the subscriber");
        }
    }
}

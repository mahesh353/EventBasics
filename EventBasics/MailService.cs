using System;

namespace EventBasics
{
    public class MailService
    {

        public void OnVideoEncoded(Object sender, EventArgs e)
        {
            Console.WriteLine("Custom event raised for sending an email : email sent");
        }

    }
}

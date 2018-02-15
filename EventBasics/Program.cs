using System;

namespace EventBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Name = ".Net Video Tutorials !" };
            VideoEncoder videoEncoder = new VideoEncoder();//publisher
            EmailService emailService = new EmailService();//subscriber

            videoEncoder.VideoEncoded += emailService.OnVideoEncoded;

            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }

    public class EmailService
    {
        public void OnVideoEncoded(Object sender, EventArgs e)
        {
            Console.WriteLine("Custom event raised for sending an email : email sent");
        }
    }
}

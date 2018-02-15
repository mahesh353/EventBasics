using System;

namespace EventBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Name = ".Net Video Tutorials !" };
            VideoEncoder videoEncoder = new VideoEncoder();//publisher
            MailService mailService = new MailService();//subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}

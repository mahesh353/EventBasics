using System;
using System.Threading;

namespace EventBasics
{
    public class VideoEncoder
    {
        //step 1 : Create the delegate
        //step2 : Define an event based on the delegate
        //step3: Raise the Event

        //Step 1 : 
        public delegate void VideoEncodedEventHandler(Object sender, EventArgs e);

        //Step 2 :
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Video Encoded");
            Thread.Sleep(5000);
            OnVideoEncoded();
        }

        //Step3: Raise the event using the method

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded!=null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}

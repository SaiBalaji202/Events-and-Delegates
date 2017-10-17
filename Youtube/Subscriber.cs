using System;

namespace Youtube
{
    class Subscriber
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public void Subscribe(Publisher publisher)
        {
            publisher.VideoUploaded += VideoUploaded;
        }

        public void VideoUploaded(object sender, VideoUploadedEventArgs e)
        {
            var _publisher = (Publisher)sender;
            Console.WriteLine(UserName + "\n\t" + _publisher.UserName + " - " + e.VideoName);
        }
    }
}
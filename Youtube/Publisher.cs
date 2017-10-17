using System;

namespace Youtube
{
    class Publisher
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        // 1. Create a Delegate
        // 2. Create a reference for that delegate
        // 3. Raise the Event

        // 1. Create a Delegate
        //public delegate void VideoUploadEventHandler(object sender, VideoUploadedEventArgs e);

        // 2. Create a reference for that delegate
        public event EventHandler<VideoUploadedEventArgs> VideoUploaded;

        public void UploadVideo(string _videoName)
        {
            // Upload a Video to the Server
            OnVideoUploaded(_videoName);
        }

        protected virtual void OnVideoUploaded(string _videoName)
        {
            if (VideoUploaded != null)
            {
                VideoUploaded(this, new VideoUploadedEventArgs()
                {
                    VideoName = _videoName
                });
            }
        }

    }
}
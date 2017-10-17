using System;

namespace Youtube
{
    class VideoUploadedEventArgs : EventArgs
    {
        public string VideoName { get; set; }
    }
}
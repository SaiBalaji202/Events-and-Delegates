namespace Youtube
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bala = new Publisher()
            {
                UserName = "Bala",
                Password = "afdfa"
            };
            var Bala1 = new Publisher()
            {
                UserName = "Bala1",
                Password = "afdfa"
            };

            var Ji = new Subscriber()
            {
                UserName = "Ji",
                Password = "afdfdf"
            };
            var Ram = new Subscriber()
            {
                UserName = "Ram",
                Password = "afdfdf"
            };

            Ram.Subscribe(Bala);
            Ram.Subscribe(Bala1);
            Ji.Subscribe(Bala);
            Bala.UploadVideo("SampleVideo.mp4");
            Bala1.UploadVideo("SV.mp4");
        }
    }
}

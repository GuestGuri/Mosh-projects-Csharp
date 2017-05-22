using System;

namespace WorkFlow
{
    public class VideoDecoder : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Run video decoder");
        }
    }
}

using System;

namespace WorkFlow
{
    public class StreamRecord : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Run stream recorder");
        }
    }
}

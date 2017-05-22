using System;

namespace WorkFlow
{
    public class WebServiceCall : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Run webservice");
        }
    }
}

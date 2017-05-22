using System;

namespace WorkFlow
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workflow)
        {
            var i = 1;
            foreach(var task in workflow.GetActivities())
            {
                Console.WriteLine("Running task {0}", i);
                task.Execute();
                Console.WriteLine("\n");
                i++;
            }
        }
    }
}

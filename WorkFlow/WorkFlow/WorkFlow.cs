using System.Collections.Generic;

namespace WorkFlow
{
    public class WorkFlow : IWorkFlow
    {
        private List<IActivity> _tasks = new List<IActivity>();

        public void Add(IActivity activity)
        {
            _tasks.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _tasks.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _tasks;
        }
    }
}

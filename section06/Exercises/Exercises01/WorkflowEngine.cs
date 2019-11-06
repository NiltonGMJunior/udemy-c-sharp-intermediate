using System.Collections.Generic;

namespace Exercises01
{
    public class WorkflowEngine
    {
        private readonly IList<IActivity> _activities;
        public WorkflowEngine()
        {
            _activities = new List<IActivity>();
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}
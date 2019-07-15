using System.Collections.Generic;

namespace _39_Interfaces_Exercise
{
    public class Workflow : IWorkflowObject
    {
        private readonly Queue<IActivity> _workflow;
        public Workflow()
        {
            _workflow = new Queue<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _workflow.Enqueue(activity);
        }

        public IEnumerable<IActivity> GetWorkFlow()
        {
            return _workflow;
        }
    }
}
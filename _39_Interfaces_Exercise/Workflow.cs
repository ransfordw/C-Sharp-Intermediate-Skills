using System.Collections.Generic;

namespace _39_Interfaces_Exercise
{
    public class Workflow : IWorkflowObject
    {
        public Workflow()
        {
            WorkFlowQueue = new Queue<IActivity>();
        }

        public Queue<IActivity> WorkFlowQueue { get ; set; }

        public void AddToQueue(IActivity activity)
        {
            WorkFlowQueue.Enqueue(activity);
        }
    }
}
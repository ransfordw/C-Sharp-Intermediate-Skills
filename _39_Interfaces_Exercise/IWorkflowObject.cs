using System.Collections.Generic;

namespace _39_Interfaces_Exercise
{
    public interface IWorkflowObject
    {
        Queue<IActivity> WorkFlowQueue { get; set; }

        void AddToQueue(IActivity activity);
    }
}

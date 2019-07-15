using System.Collections.Generic;

namespace _39_Interfaces_Exercise
{
    public class WorkflowEngine
    {
        public WorkflowEngine()
        {
        }

        public void Run(IWorkflowObject workflowObject)
        {
            foreach(var activity in workflowObject.WorkFlowQueue)
            {
                activity.Execute();
            }
        }
    }
}

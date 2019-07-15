using System;

namespace _39_Interfaces_Exercise.Activities
{
    public class MediaOwnerUpdate : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Update the owner: your media is being processed.");
        }
    }
}
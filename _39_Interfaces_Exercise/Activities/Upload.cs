using System;

namespace _39_Interfaces_Exercise.Activities
{
    public  class Upload : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Media is being uploaded.");
        }
    }
}
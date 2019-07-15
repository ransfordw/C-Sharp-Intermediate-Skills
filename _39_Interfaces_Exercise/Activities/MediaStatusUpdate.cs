using System;

namespace _39_Interfaces_Exercise.Activities
{
    public class MediaStatusUpdate : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Media Status: media is being processed.");
        }
    }
}
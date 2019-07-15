using System;

namespace _39_Interfaces_Exercise.Activities
{
    public class ThirdPartyEncoderRequest : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Third party encoder requested for upload.");
        }
    }
}
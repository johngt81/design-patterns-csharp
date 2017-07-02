using System;

namespace Observer
{
    public class SMSObserver : IObserver
    {
        public void Notify(Docket docket)
        {
            Console.Out.WriteLine($"SMS sent - New docket #:{docket.DocketNumber}");
        }
    }
}

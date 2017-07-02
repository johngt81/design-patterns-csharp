using System;

namespace Observer
{
    public class EmailObserver : IObserver
    {
        public void Notify(Docket docket)
        {
            Console.WriteLine($"Email sent - A new docket was created. Docket # {docket.DocketNumber} Text: {docket.DocketText} Filed on: {docket.FileDate.ToShortDateString()}");
        }
    }
}

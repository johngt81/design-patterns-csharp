using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailObserver = new EmailObserver();
            var smsObserver = new SMSObserver();

            DocketData subject = new DocketData();
            subject.RegisterObserver(emailObserver);
            subject.RegisterObserver(smsObserver);

            Docket efhDocket = new Docket()
            {
                DocketId = 1,
                DocketNumber = "123",
                DocketText = "Docket filed for the case Energy Future Holdings",
                FileDate = new DateTime(2017,6,28)
            };

            subject.NewDocketAdded(efhDocket);

            Docket daiDocket = new Docket()
            {
                DocketId = 2,
                DocketNumber = "456",
                DocketText = "Docket filed for the case Delta Airlines",
                FileDate = new DateTime(2017, 6, 29)
            };

            subject.NewDocketAdded(daiDocket);

            subject.RemoveObserver(emailObserver);

            Docket cscDocket = new Docket()
            {
                DocketId = 3,
                DocketNumber = "89",
                DocketText = "Docket filed for the case Corporation Services",
                FileDate = new DateTime(2017, 7, 29)
            };

            subject.NewDocketAdded(cscDocket);
            Console.ReadLine();
        }
    }
}

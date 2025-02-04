using System;
using System.Collections.Generic;
using System.Text;

namespace eventdelegate
{
    class Event
    {
        static void Main(string[] args)
        {
           
            video v = new video();
            v.set("Vikranth Rona");
            Console.WriteLine(v.get());

            messageservice ms = new messageservice();
            mailservice mas = new mailservice();
            videoencode ve = new videoencode();

            ve.encodeevent += ms.videodemand;
            ve.encodeevent += mas.onvideodemand;
            ve.Encode(v);
        }
    }
}

       

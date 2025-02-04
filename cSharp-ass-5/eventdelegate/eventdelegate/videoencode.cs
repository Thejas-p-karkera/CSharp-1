using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace eventdelegate
{
    class videoencode
    {
        public delegate void encodedelegate();
        public event encodedelegate encodeevent;
        public void Encode(video v)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(1000);
            if (encodeevent != null)
            {
                encodeevent();
            }
        }

    }
}

    

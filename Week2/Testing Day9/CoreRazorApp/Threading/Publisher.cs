using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public delegate void MyDeligate(string msg);

    public class Publisher
    {
        public event MyDeligate MyEvent;

        public void EventMethod(string m)
        {
            MyEvent.Invoke("Publisher class Event Invoked with message" + m);
        }

    }
    public class Subscriber
    {
        public void SubscriberMehod(string m)
        {
            Console.WriteLine("Subscriber Method is called with message " + m);
        }
    }
}

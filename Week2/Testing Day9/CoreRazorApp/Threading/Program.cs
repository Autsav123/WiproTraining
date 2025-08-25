// Thraeding is the process top make the process asynchronus from synchronus for faster processing
using Threading;
   /* ThreadingExample cs = new ThreadingExample();
Thread t1 = new Thread(cs.Even);
Thread t2 = new Thread(cs.Odd);
t1.Start();
Thread.Sleep(5000);
t2.Start();
t1.Join();// This is usd to make the process again syncronus it is used let suppose you have 7 thread and 5 & 6 are interdependent then we use it
//cs.Even();
///cs.Odd();*/
///

Publisher p = new Publisher();
Subscriber s = new Subscriber();
p.MyEvent += s.SubscriberMehod;
p.EventMethod("Method Parameyter");
Console.ReadLine();
    
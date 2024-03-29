// See https://aka.ms/new-console-template for more information
using CS009_Event;

Console.WriteLine("Hello, World!");

void TestDelegate()
{
    Publisher p = new();
    SubscriberA sa = new();
    SubscriberB sb = new();

    sa.Sub(p);
    sb.Sub(p);

    p.Send();
}

TestDelegate();
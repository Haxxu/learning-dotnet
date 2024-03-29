using System;

namespace CS009_Event
{
    public class Publisher
    {
        public delegate void NotifyNews(object data);

        public NotifyNews? event_news;

        public void Send()
        {
            event_news?.Invoke("Co tin moi");
        }
    }

    public class SubscriberA
    {
        public void Sub(Publisher p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("SubscriberA: " + data.ToString());
        }
    }

    public class SubscriberB
    {
        public void Sub(Publisher p)
        {
            // p.event_news = null;
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("SubscriberB: " + data.ToString());
        }
    }
}
using RabbitMQ.Client;
using System;

namespace TotalAvailableSeatProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hellow")
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            var conn = factory.CreateConnection();
            var chan = conn.CreateModel();
            QueueProducer.Publish(chan);
        }
    }
}

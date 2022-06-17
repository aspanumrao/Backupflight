using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Service.FlightSearchAPI
{
    public static class QueueConsumer
    {
        public static string Consume(RabbitMQ.Client.IModel channel)
        {
            string message1=string.Empty;
            channel.QueueDeclare("demo1-rabbitQ1",
             durable: true,
             exclusive: false,
             autoDelete: false,
             arguments: null
              );
            var consumer = new RabbitMQ.Client.Events.EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                message1 = message;
            };
            channel.BasicConsume("demo1-rabbitQ1", true, consumer);
            return message1;
        }
    }
}

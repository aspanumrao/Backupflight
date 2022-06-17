using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using Flight.Service.BookingAPI.Model;

namespace Flight.Service.BookingAPI
{
    public static class QueueProducer
    {
        public static void Publish(RabbitMQ.Client.IModel channel,BookingTbl bookingTbl)
        {
            channel.QueueDeclare("demo1-rabbitQ1",
               durable: true,
               exclusive: false,
               autoDelete: false,
               arguments: null
                );
            var  numberofseatbooked = bookingTbl.NoOfSeat;
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(numberofseatbooked));
            channel.BasicPublish("", "demo1-rabbitQ1", null, body);        
        }      
    }
}

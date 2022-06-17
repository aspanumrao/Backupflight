using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace TotalAvailableSeatProducer
{
    class QueueProducer
    {
        public static void Publish(IModel channel)
        {
            channel.QueueDeclare("TotalSeat-Q1",
               durable: true,
               exclusive: false,
               autoDelete: false,
               arguments: null
                );
            int count = 0;
            //var message = new { Name = "Team21", Message = $"Hello Team Count:{count}" };
            Emp emp = new Emp();
            emp.id = 1;
            emp.empname = "XYZ";
            emp.depart = "IT";

            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(emp));
            channel.BasicPublish("", "TotalSeat-Q1", null, body);
            Console.WriteLine("Producer Started");
            Console.ReadLine();
        }
        public class Emp
        {
            public int id { get; set; }
            public string empname { get; set; }

            public string depart { get; set; }
        }
    }
}

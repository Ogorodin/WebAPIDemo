using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UserActivityHandlerService
{
    public class RabbitMqNotifier
    {

        public static void Start()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "New registrations",
                                  durable: false,
                                  exclusive: false,
                                  autoDelete: false,
                                  arguments: null);

                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += OnMessageRecieved;
                    channel.BasicConsume(queue: "New registrations",
                                         autoAck: true,
                                         consumer: consumer);

                    Console.WriteLine(" Press [enter] to exit.");
                    Console.ReadLine();
                }
            }
        }

        static void OnMessageRecieved(object user, BasicDeliverEventArgs args)
        {
            var body = args.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine(" [x] Message Received {0}", message);
            Console.WriteLine("Processing...");
            Thread.Sleep(2500);
            Console.WriteLine("Processed.");

        }
    }
}

using DataLayer.Repository;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDemo.Services
{
    public class MessageService : IMessageService
    {
        public void NotifyRabbit(string username, string email)
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

                    string message = $"User {username} registered. E-mail: { email } ";

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                         routingKey: "New registrations",
                                         //     basicProperties: null,
                                         body: body);
                    
                }
            }
        }
    }

}

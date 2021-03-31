using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace UserActivityHandlerService
{
    class Program
    {
        static void Main(string[] args)
        {
            RabbitMqNotifier.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Reflection.Example
{
    public class Order
    {
        private readonly int _id;
        public int Id { get; set; }
        public string Client { get; set; }
        public bool Active { get; set; }
        protected object Object { get; set; }

        public Order()
        {

        }

        public Order(int id)
        {
            Id = id;
        }

        public Order(int id, string client, bool active, object @object)
        {
            Id = id;
            Client = client;
            Active = active;
            Object = @object;
        }

        public bool Execute() => true;

        public string Execute(string x) => x;

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   _id == order._id &&
                   Id == order.Id &&
                   Client == order.Client &&
                   Active == order.Active &&
                   EqualityComparer<object>.Default.Equals(Object, order.Object);
        }

        public void PrintNow() => Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");

        public override int GetHashCode()
        {
            return HashCode.Combine(_id, Id, Client, Active, Object);
        }
    }
}

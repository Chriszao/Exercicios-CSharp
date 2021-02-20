using System;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Momemnt { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ($"{Id}, {Momemnt}, {Status}.");
        }

    }
}

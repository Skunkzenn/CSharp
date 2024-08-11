﻿using Exercise_Enumeracoes_Composicoes_com_UML.Entities.Enum;
using System.Text;

namespace Exercise_Enumeracoes_Composicoes_com_UML.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { 
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items) {
                total += item.SubTotal();    
            }
            return total;
        }
    }
}

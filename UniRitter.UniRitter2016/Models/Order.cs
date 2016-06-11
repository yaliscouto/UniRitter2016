using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniRitter.UniRitter2016.Models
{

    public enum OrderStatus
    {
        new_,
        processed,
        invoiced,
        delivered,
        canceled
    }

    public class OrderItens
    {
        int quantity { get; set; }
        Guid? product_id { get; set; }
        decimal price { get; set; }
    }

    public class Order
    {
         Guid? id { get; set; }
         public OrderStatus status { get; set; }
         public decimal total { get; set; }
         public DateTime created_on { get; set; }
         public DateTime updated_on { get; set; }
         public List<OrderItens> items { get; set; }
    }
}
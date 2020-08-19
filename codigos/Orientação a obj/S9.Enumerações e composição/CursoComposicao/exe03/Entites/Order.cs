using System;
using System.Collections.Generic;
using exe03.Entites.Enums;

namespace exe03.Entites {
  public class Order {
    public DateTime Moment { get; set; }
    public Client Client { get; set; }
    public OrderStatus Status { get; set; } 
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public Order(){

    }
    
    public Order (Client client, OrderStatus status) {
      Moment = DateTime.Now;
      Client = client;
      Status = status;
    }

    public void AddItems(OrderItem item){
      Items.Add(item);
    }

    public void RemoveItems(OrderItem item){
      Items.Remove(item);
    }


  }
}
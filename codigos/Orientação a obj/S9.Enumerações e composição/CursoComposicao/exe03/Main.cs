using System;
using System.Globalization;
using exe03.Entites;
using exe03.Entites.Enums;

namespace exe03 {
  class Program {
    static void Main (string[] args) {
      Client client;
      OrderItem item;
      Product product;
      Order order;

      Console.WriteLine ("Enter cliente data:");
      Console.Write("Name: ");
      string name = Console.ReadLine();
      Console.Write("Email: ");
      string email = Console.ReadLine();
      Console.Write("Birth date (DD/MM/YYYY): ");
      DateTime date = DateTime.Parse(Console.ReadLine());
      //INSTANCIANDO O CLIENTE
      client = new Client(name, email, date);
      Console.Clear();
      
      Console.WriteLine("Enter order data:");
      Console.Write("Status: ");
      OrderStatus status = Enum.Parse<OrderStatus> (Console.ReadLine ());
      Console.Write("How many items to this order? ");
      int n = int.Parse(Console.ReadLine());
      Console.Clear();

      //Instanciando Order
      order = new Order(client, status);

      for(int i = 0; i < n; i++){
        Console.WriteLine($"Enter #{i+1} item data: ");
        Console.Write("Product name: ");
        string prodName = Console.ReadLine();
        Console.Write("Product price: R$ ");
        double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantity: ");
        int qtd = int.Parse(Console.ReadLine());
        
        //INSTANCIANDO O PRODUTO
        product = new Product(prodName, prodPrice);
        //INSTANCIANDO O CARRINHO DE PEDIDO
        item = new OrderItem(product, prodPrice, qtd);

        order.AddItems(item);
      }

      Console.Clear();
      Console.WriteLine("ORDER SUMARY:");
      Console.WriteLine("Order Moment: " + order.Moment.ToString("dd/MM/yyyy hh:mm:ss"));
      Console.WriteLine("Order Status: " + order.Status);
      Console.WriteLine("Client: " + order.Client.Name + " (" + order.Client.BirthDate.ToString("dd/MM/yyyy") + ") " 
                         + order.Client.Email);
      Console.WriteLine("Ordem Items: ");

      double total = 0;
      foreach (OrderItem i in order.Items){
        Console.WriteLine(i.Product.Name + ", Quantity: " + i.Quantity + ", SubTotal: R$ " + i.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
        total += i.SubTotal();
      }
      Console.WriteLine("Total Price: R$ " + total);

      
    }
  }
}
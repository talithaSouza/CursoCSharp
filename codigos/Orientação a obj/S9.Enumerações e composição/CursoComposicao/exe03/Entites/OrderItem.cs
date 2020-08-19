namespace exe03.Entites {
  public class OrderItem {
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Product Product { get; set; } 

    public OrderItem () {

    }

    public OrderItem (Product product, double price, int quantity) {
      Product = product;
      Quantity = quantity;
      Price = price;
    }

    public double SubTotal(){
      return Quantity * Price;
    }

  }
}
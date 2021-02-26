using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int CustomerOrder { get; set;}

    public Bread(int customerOrder)
    {
      CustomerOrder = customerOrder;
    }

    public int BreadOrderPrice()
    {
      if (CustomerOrder % 3 == 0)
      {
        int totalPrice = (CustomerOrder - (CustomerOrder / 3)) * 5;
        return totalPrice;
      }
      else
      {
        return CustomerOrder * 5;
      }
    }
  }
  
}
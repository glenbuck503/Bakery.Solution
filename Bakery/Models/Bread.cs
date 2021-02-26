using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int CustomerOrder { get; set;}
    public string BreadType {get; set;} //further

    public Bread(int customerOrder, string breadType) //string breadType further
    {
      CustomerOrder = customerOrder;
      BreadType = breadType; // further
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
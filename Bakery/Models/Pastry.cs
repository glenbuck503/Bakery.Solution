using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int CustomerPastry {get; set;}

    public Pastry(int customerOrder)
    {
      CustomerPastry = customerOrder;
      
    }

    public int PastryOrderPrice()
    {
      if (CustomerPastry % 3 == 0)
      {
        int price = (CustomerPastry / 3) * 5;
        return price;
      }
      else if (CustomerPastry % 3 > 0 && CustomerPastry > 3)
      {
        int price = ((CustomerPastry / 3) * 5) + ((CustomerPastry % 3) * 2);
        return price;
      }
      else
      {
        return CustomerPastry * 2;
      }
    }
  }

}
  
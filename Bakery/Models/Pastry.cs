using System;

namespace Pastry.Models
{
  public class Pastry
  {
    public int CustomerPastry {get; set;}

    public Pastry(int customerOrder)
    {
      CustomerPastry = customerOrder;
      //trying to figure out logic
    }
  }

}
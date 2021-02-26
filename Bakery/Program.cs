using System;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome To Pierre's Bakery Shop!");
      Console.WriteLine("Bread is $5 a loaf. BREAD SPECIAL: Buy 2 get 1 free!");
      Console.WriteLine("Pastries are $2 each. PASTRY SPECIAL: Buy 3 for $5!");
      Console.WriteLine("How many loaves of bread would you like? :");
      int custBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like? :");
      int custPastry = int.Parse(Console.ReadLine());

      Bread breadOrder = new Bread(custBread);
      Pastry pastryOrder = new Pastry(custPastry);
      
      Console.WriteLine($"Your bread order total price is ${breadOrder.BreadOrderPrice()} ");
    }
  }
}


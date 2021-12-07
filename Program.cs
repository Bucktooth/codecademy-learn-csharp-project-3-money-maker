using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins: ");
      string totalAsString = Console.ReadLine();
      double totalAsDouble = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{totalAsDouble} cents is equal to...");
      int goldValue = 10;
      int silverValue = 5;

      // Peform coin operations
      double goldCoins = Math.Floor(totalAsDouble / goldValue);
      double leftOver = totalAsDouble % goldValue;
      double silverCoins = Math.Floor(leftOver / silverValue);
      leftOver = leftOver % silverValue;

      // Print out the coins the amount divies up into
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {leftOver}");
    }
  }
}

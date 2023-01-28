using System;

class Program {
  public static void Main () {
    Console.WriteLine("What day is it today");
    //int day = 1;
    string day = Console.ReadLine();
    switch (day)
    {
    case "mon" or "monday":
      Console.WriteLine("Today is Monday");
      Console.WriteLine("~ Go to math academy~");
      break;
    case "tuse" or "tuseday":
      Console.WriteLine("Tuseday");
      Console.WriteLine("~ Go to english academy~");
      break;
    case "wedn" or "wednesday":
      Console.WriteLine("Wednesday");
      Console.WriteLine("~ Go to math academy~");
      break;
    case "thur" or "thursday":
      Console.WriteLine("Thursday");
      Console.WriteLine("~ Go to english academy~");
      break;
    case "fri" or "friday":
      Console.WriteLine("Friday");
      Console.WriteLine("~ Go to math academy~");
      break;
    case "sat" or "saturday":
      Console.WriteLine("Saturday");
      Console.WriteLine("~ Go to coding academy~");
      break;
    case "sun" or "sunday":
      Console.WriteLine("Sunday");
      Console.WriteLine("~ play~");
      break;
    }
  }
}
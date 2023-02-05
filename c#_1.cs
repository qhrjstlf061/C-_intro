using System;

class Program
{
    public static void Main(string[] args)
    {
        //while loop
        int x = 1;
        int y = 2;
        while(x<y)
        {
          Console.WriteLine("T.I.S.H");
          x++;
        }
        //nested for loop
        int i = 0;
        for (i = 0; i < 10; i+=2)
        {
          Console.WriteLine(i);
          for (int j =1; j<=3; j++)
          {
            Console.WriteLine("T.I.S.H");
            for (int d = 0; d<3; d++)
            {
              Console.WriteLine("H.T.I.S.H");
            }
          }
        }
      string[] cars = {"Kia", "Hyun", "Hon", "Ford", "BMW"};
      foreach(string c in cars)
      {
        Console.WriteLine(c);
      }
    }
}
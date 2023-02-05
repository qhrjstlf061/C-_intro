using System;

class Program {
  public static void Main (string[] args) {
    int[,] combo = {{35,52,98},{15,17,92},{78,62,41}};
    int[] tester = {6,3,7,1,46,8,1,0};
    // foreach(int j in combo)
    // {
    //   for (int i = 0; i <= 100; i++)
    //   {
    //     if (i == j)
    //     {
    //       Console.WriteLine ("The Lock has been opened");
    //       Console.WriteLine (j);
    //     }
    //   }
    // }
    Console.WriteLine (combo[0,1]);
    Console.WriteLine (combo[1,1]);
    Console.WriteLine (combo[2,1]);
    
  }
}
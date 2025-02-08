using System;
class Problem1Class {
  public static void Main (string[] args) {

    int squareSize = int.Parse(Console.ReadLine());
    
    for (int i = 0; i < squareSize; i++) {
      for (int j = 0; j < squareSize; j++){
        Console.Write("* ");
      }
      Console.WriteLine();
    }
  }
}

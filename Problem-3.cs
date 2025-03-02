using System;
class Problem3Class {
  public static void Main (string[] args) {

int countOfNegativeNumbers = 0;

for (int i = 0; i < 3; i++)
    {
      int num = int.Parse(Console.ReadLine());
      if (num < 0)
      {
        countOfNegativeNumbers++;
      }
    }
if (countOfNegativeNumbers % 2 != 0 && countOfNegativeNumbers != 0)
    {
      Console.WriteLine("negative");
    }
    else if (countOfNegativeNumbers % 2 == 0 && countOfNegativeNumbers != 0)
    {
      Console.WriteLine("positive");
    }
    else if (countOfNegativeNumbers == 0)
    {
      Console.WriteLine("zero");
    }
    }
  }
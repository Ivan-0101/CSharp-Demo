using System;
using System.Linq;
using System.Collections.Generic;

class Problem7Class {
  public static void Main (string[] args) {

      List<int> input = Console.ReadLine()
          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse)
          .ToList();

      List<int> bomb = Console.ReadLine()
          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse)
          .ToList();

      int bombNum = bomb[0];
      int bombPow = bomb[1];

      for (int index = 0; index <= input.Count - 1; index++)
      {
          if (input[index] == bomb[0])
          {
              int startIndex = index - bombPow;
              int removeCount = bombPow + bombPow + 1;

              if (startIndex < 0)
              {
                  removeCount -= Math.Abs(startIndex);
                  startIndex = 0;
              }
              if (startIndex + removeCount > input.Count)
              {
                  removeCount = input.Count - startIndex;
              }

              input.RemoveRange(startIndex, removeCount);
              index = startIndex - 1;
          }
      }

      int sum = input.Sum();
      Console.WriteLine(sum);
      }
    }
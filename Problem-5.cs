using System;
using System.Linq;
using System.Collections.Generic;

class Problem5Class {
  public static void Main (string[] args) {

      List<int> numbers1 = Console.ReadLine()
          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse)
          .ToList();

      List<int> numbers2 = Console.ReadLine()
          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse)
          .ToList();

      List<int> resultList = new List<int>();

      int longerList = Math.Max(numbers1.Count, numbers2.Count);

      for (int index = 0; index <= longerList - 1; index++)
      {
          if (numbers1.Count - 1 >= index)
          {
              resultList.Add(numbers1[index]);
          }
          if (numbers2.Count - 1 >= index)
          {
              resultList.Add(numbers2[index]);
          }
      }

      Console.WriteLine(string.Join(" ", resultList));
      }
    }
using System;
class Problem4Class {
  public static void Main (string[] args) {

List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

while (numbers.Count > 1)
{
    List<int> summedNumbers = new List<int>();

    for (int index = 0; index <= numbers.Count - 2; index++)
    {
        summedNumbers.Add(numbers[index] + numbers[index + 1]);
    }

    numbers = summedNumbers;
}

Console.WriteLine(string.Join(" ", numbers));
      }
    }
using System;

class Person {
  public string FirstName;
  public string LastName;
}

class Program {
  public static void Main(string[] args) {
    Person person1 = new Person();

    person1.FirstName = "John";
    person1.LastName = "Doe";

    Console.WriteLine($"Name: {person1.FirstName} {person1.LastName}");
  }
}
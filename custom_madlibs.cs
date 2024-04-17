using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This progrma is a MadLib word game and is intended to be fun!
      Author: Created by Jake McGreevy
      */


      // Let the user know that the program is starting:
      Console.WriteLine("The game is now starting!");


      // Give the Mad Lib a title:
      string title = "Mad Libs Game v1.0";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Enter a name of the main character: ");
      string name = Console.ReadLine();
     
      Console.WriteLine("Please enter in your first adjective: ");
      string adjectiveOne = Console.ReadLine();
      Console.WriteLine("Please enter in your second adjective: ");
      string adjectiveTwo = Console.ReadLine();
      Console.WriteLine("Please enter in your third adjective: ");
      string adjectiveThree = Console.ReadLine();
      
      Console.WriteLine("Next, please enter in a verb: ");
      string verb = Console.ReadLine();
      
      Console.WriteLine("Now we need your first noun: ");
      string nounOne = Console.ReadLine();
      Console.WriteLine("Now we need your second noun: ");
      string nounTwo = Console.ReadLine();
     
      Console.WriteLine("Lastly, please enter one of each of the following:");
      Console.WriteLine("An animal: ");
      string animal = Console.ReadLine();
      Console.WriteLine("A food: ");
      string food = Console.ReadLine();
      Console.WriteLine("A fruit: ");
      string fruit = Console.ReadLine();
      Console.WriteLine("A superhero: ");
      string superhero = Console.ReadLine();
      Console.WriteLine("A country: ");
      string country = Console.ReadLine();
      Console.WriteLine("A dessert: ");
      string dessert = Console.ReadLine();
      Console.WriteLine("A year: ");
      string year = Console.ReadLine();
      

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}

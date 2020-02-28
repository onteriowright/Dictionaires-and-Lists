using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Mars" };
      planetList.Add("Jupiter");
      planetList.Add("Saturn");

      List<string> newPlantList = new List<string>() { "Jupiter", "Mars" };

      planetList.AddRange(newPlantList);

      planetList.Insert(1, "Earth");
      planetList.Insert(2, "Venus");

      planetList.Add("Pluto");

      string[] rockyPlanets = planetList.GetRange(0, 4).ToArray();

      planetList.Remove("Pluto");

      foreach (string planet in planetList)
      {
        Console.WriteLine(planet);
      }
      foreach (string rocky in rockyPlanets)
      {
        Console.WriteLine(rocky);
      }

      Random random = new Random();
      List<int> numbers = new List<int> {
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
};

      for (int i = 0; i < numbers.Count; i++)
      {
        if (numbers.Contains(i))
        {
          Console.WriteLine($"Numbers list contains {i}");
        }
        else
        {
          Console.WriteLine($"Numbers list does not contain {i}");
        }
      }

      Dictionary<string, int> toysSold = new Dictionary<string, int>() {
    {"Hot Wheels", 344},
    {"Legos", 763},
    {"Gaming Consoles", 551},
    {"Board Games", 298}
};

      toysSold.Add("Bicycles", 87);

      Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

      wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
      wordsAndDefinitions.Add("Great", "The feeling of students when it is Friday");
      wordsAndDefinitions.Add("Lazy", "The feeling of students when it is Monday");
      Console.WriteLine(wordsAndDefinitions["Great"]);
      Console.WriteLine(wordsAndDefinitions["Awesome"]);

      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
        Console.WriteLine($"The definition of {word.Key} is {word.Value} ");
      }

      List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

      Dictionary<string, string> excitedWords = new Dictionary<string, string>();

      excitedWords.Add("word", "Happy");
      excitedWords.Add("definition", "Excited, Cheerful, Jolly");
      excitedWords.Add("part of speech", "adjective");
      excitedWords.Add("example sentence", "The student's are happy it's Friday");

      dictionaryOfWords.Add(excitedWords);
      Dictionary<string, string> badWords = new Dictionary<string, string>();

      badWords.Add("word", "Upset");
      badWords.Add("definition", "Mad, Furious, Not Happy");
      badWords.Add("part of speech", "adjective");
      badWords.Add("example sentence",
        "The student's were upset about the cold weather");

      dictionaryOfWords.Add(badWords);
      foreach (Dictionary<string, string> words in dictionaryOfWords)
      {
        foreach (KeyValuePair<string, string> word in words)
        {
          Console.WriteLine($"{word.Key}: {word.Value}");
        }
      }


      Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();

      idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
      idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
      idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
      idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
      idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
      idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
      idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
      idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
      idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
      idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

      foreach (KeyValuePair<string, List<string>> word in idioms)
      {
        Console.WriteLine($"{word.Key}, {String.Join(" ", word.Value)} ");
      }
    }
  }
}

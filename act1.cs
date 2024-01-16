using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Game Start");
        Console.WriteLine ("Game Descrip");
        
        Console.WriteLine("What's your name? :");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is: " + name);
        
        Console.WriteLine ("You start with a sword, armor, and 100 base HP and MP");
        int x = 100;
        int y = 100;
        
        Console.WriteLine ("Where will you head of to?: ");
        Thread.Sleep(1000);
        Console.WriteLine ("The places with quests are:");
        Thread.Sleep(1000);
        Console.WriteLine ("Cave");
        Thread.Sleep(1000);
        Console.WriteLine ("Dungeon");
        Thread.Sleep(1000);
        Console.WriteLine ("Forest");
        string place = Console.ReadLine();
        
        string a = "Cave";
        string b = "Dungeon";
        string c = "Forest";
        
        if (place == "Cave")
        {
        Console.WriteLine ("You have decided to go to the " + a); 
        }
        
        else if (place == "Dungeon")
        {
        Console.WriteLine ("You have decided to go to the " + b);
        }
        
        else if (place == "Forest")
        {
        Console.WriteLine ("You have decided to go to the " + c);
        }
        
    }
}

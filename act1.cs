using System;
using System.Threading;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Game Start!!!");
        Thread.Sleep(1000);
        Console.WriteLine ("In the realm of Runettera, a lone adventurer emerges.The adventurer goes and ventures out to discover treasures yet to be uncovered by man. Guided by destiny, he embarks on a perilous journey using his abilities with the sword and determination to grab treaures for his own. With his skills by his side, he must venture to unknown places, fight monsters, and prevent himself from dying from his own choices. You are that adventurer and must pick the correct choices in order to discover treasures and not die.");
        Thread.Sleep(300);
        string line = "__________________________________________";
        Console.WriteLine("What's your name adventurer? :");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is: " + name);
        Thread.Sleep(500);
        
        Console.WriteLine (line + Environment.NewLine + "You start with a sword, armor, and 100 base HP and MP.");
        int x = 100;
        int y = 100;

        
        Console.WriteLine (line + Environment.NewLine + "Where will you head of to?: ");
        Thread.Sleep(800);
        Console.WriteLine ("The places with quests are:");
        Thread.Sleep(800);
        Console.WriteLine ("|||Cave|||");
        Thread.Sleep(800);
        Console.WriteLine ("|||Dungeon|||");
        Thread.Sleep(800);
        Console.WriteLine ("|||Forest|||");
        string place = Console.ReadLine();
        
        string a = "Cave";
        string b = "Dungeon";
        string c = "Forest";
        
        Console.OutputEncoding = Encoding.UTF8;
        string cave = "    ⛰️    ";
        string dungeon = "    🏰    ";
        string forest = "    🌲    ";
        string dead = "    💀    ";
        
        if (place == "Cave")
        {
        Console.WriteLine (line + Environment.NewLine + "You have decided to go to the " + a);
        Console.WriteLine (cave);
        Thread.Sleep(1000);
        Console.WriteLine ("You have entered the cave. Their appears to be 2 pathways. Left or Right. Where will you go?");
            string path = Console.ReadLine();
            if (path == "Right")
            {
            Thread.Sleep(1000);
            Console.WriteLine ("You decided to go right and light does not reach but there's an unlit torch next to you. Will you light it?");
            Console.WriteLine ("YES or NO");
                string choice_1 = Console.ReadLine();
            Thread.Sleep(1000);
                if (choice_1 == "YES")
                {
                Console.WriteLine ("You have lit the torch and an undead has aproached you. Prepare for battle.");
                }   
                else if (choice_1 == "NO")
                {
                Console.WriteLine ("You died." + dead);
                }
            }
        }
        
        else if (place == "Dungeon")
        {
        Console.WriteLine (line + Environment.NewLine + "You have decided to go to the " + b);
        Console.WriteLine (dungeon);
        }
        
        else if (place == "Forest")
        {
        Console.WriteLine (line + Environment.NewLine + "You have decided to go to the " + c);
        Console.WriteLine (forest);
        }
        
    }
}

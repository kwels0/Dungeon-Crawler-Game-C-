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
        
        Console.WriteLine (line + Environment.NewLine + "You start with a sword, armor, and 100 base HP.");
        int health = 100;
        int magic = 100;

        
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
        Console.WriteLine (line + Environment.NewLine + "You have decided to go to the " + a + cave + Environment.NewLine + line);
        Thread.Sleep(1000);
        Console.WriteLine ("You have entered the cave. Their appears to be 2 pathways. Where will you go?" + Environment.NewLine + line + Environment.NewLine + "Right or Left?" + Environment.NewLine + line);
            string path = Console.ReadLine();
            if (path == "Right")
            {
            Thread.Sleep(1000);
            Console.WriteLine ("You decided to go right. Light does not reach but there's an unlit torch next to you. Will you light it?");
            Console.WriteLine ("Yes or No");
                string choice_1 = Console.ReadLine();
            Thread.Sleep(1000);
                if (choice_1 == "Yes")
                {
                Console.WriteLine ("You have lit the torch and an undead has noticed you. Prepare for battle.");
                Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
                int move = Convert.ToInt32(Console.ReadLine());
                switch (move)
                {
                    case 1:
                    Console.WriteLine ("You attacked it with your sword.");
                    Thread.Sleep(700);
                    Console.WriteLine ("It died.");
                    break;
                    
                    case 2:
                    Console.WriteLine ("Talk");
                    
                    break;
                    
                    case 3: 
                    Console.WriteLine ("Flee");
                    break;
                }
                }   
                else if (choice_1 == "No")
                {
                Console.WriteLine ("You died." + dead);
                }
            }
            else if (path == "Left")
            {
            Console.WriteLine ("You decided to go right. You have encountered a chest. Will you open it?" + Environment.NewLine + "Yes or No");
                string choice = Console.ReadLine ();
                if (choice == "Yes")
                {
                Console.WriteLine ("It was a mimic and you were eaten. You have died." + dead);
                }
                else if (choice == "No")
                Console.WriteLine ("You have decided to not open the chest. You continued your path and discovered it was a dragon's cave.");
                Thread.Sleep(1000);
                Console.WriteLine ("The dragon has awoken due to your presence prepare for battle.");
            }
        }
        
        else if (place == "Dungeon")
        {
        Console.WriteLine (line + Environment.NewLine + "You have decided to go to the " + b);
        Console.WriteLine (dungeon);
        
        Console.WriteLine ("You are inside the dungeon there is a pile of dead bodies in the entrance and there is a monster looting them." + Environment.NewLine + "Will you Attack or Sneak around?");
        
        String d_choice_1 = Console.ReadLine();
        if (d_choice_1 == "Attack")
        {
        Console.WriteLine ("Prepare for battle");
        Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
        int move = Convert.ToInt32(Console.ReadLine());
        switch (move)
        {
                    case 1:
                    Console.WriteLine ("1. Attack with your sword");
                    break;
                    
                    case 2:
                    Console.WriteLine ("2. Talk");
                    break;
                    
                    case 3: 
                    Console.WriteLine ("3. Flee");
                    break;
        }
            if (move == 1)
            {
            Console.WriteLine ("You have killed the undead. Gained a bone.");    
            }
        }
        else if (d_choice_1 == "Sneak around")
        {
        Console.WriteLine ("Sneaking around was succesful you are now in the boss room");    
        }
        }
        
        else if (place == "Forest")
        {
        Console.WriteLine (line + Environment.NewLine + "You have decided to go to the " + c);
        Console.WriteLine (forest);
        }
        
    }
}

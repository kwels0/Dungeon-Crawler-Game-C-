using System;
using System.Threading;
using System.Text;

public class Game
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Game Start!!!");
        Thread.Sleep(1000);
        Console.WriteLine ("In the realm of Runettera, a lone adventurer emerges.The adventurer goes and ventures out to discover treasures yet to be uncovered by man. Guided by destiny, he embarks on a perilous journey using his abilities with the sword and determination to grab treaures for his own. With his skills by his side, he must venture to unknown places, fight monsters, and prevent himself from dying from his own choices. You are that adventurer and must pick the correct choices in order to discover treasures and avoid death.");
        Thread.Sleep(800);
        string line = "__________________________________________";
        Console.WriteLine(line + Environment.NewLine + "What's your name adventurer? :");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is: " + name);
        Thread.Sleep(800);
        
        Console.WriteLine (line + Environment.NewLine + "You start with a sword, armor, and 100 base HP.");

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
        Console.WriteLine (line + Environment.NewLine + "You have decided to go to the " + a + "\n" + cave + Environment.NewLine + line);
        Thread.Sleep(1000);
        Console.WriteLine ("You have entered the cave. Their appears to be 2 pathways. Where will you go?" + Environment.NewLine + line + Environment.NewLine + "Right or Left?" + Environment.NewLine + line);
            string path = Console.ReadLine();
            if (path == "Right")
            {
            Thread.Sleep(700);
            Console.WriteLine ("You decided to go right. Light does not reach but there's an unlit torch next to you. Will you light it?");
            Console.WriteLine ("Yes or No");
                string choice_1 = Console.ReadLine();
            Thread.Sleep(1000);
                if (choice_1 == "Yes")
                {
                Console.WriteLine ("You have lit the torch and a skeleton warrior has noticed you. Prepare for battle.");
                Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
                start_1:
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
                        if (move == 1)
                        {
                        Console.WriteLine ("You have killed the undead. Gained a bone." + Environment.NewLine + line);   
                        Thread.Sleep(1000);
                        Console.WriteLine ("Killing the undead was a trap. The Skeleton boss was alarmed.");
                        Thread.Sleep(500);
                        Console.WriteLine ("Get ready to fight the boss." + Environment.NewLine + "Battle Start!");
                        Thread.Sleep(800);
                        Console.WriteLine ("The Skeleton boss has 100HP");
                        }
                        
                        else if (move == 2)
                        {
                        Console.WriteLine ("The undead does not have a mouth so it just rattles.");
                        Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
                        goto start_1;
                        }
                        else if (move == 3)
                        {
                        Console.WriteLine ("You have fled the battle.");
                        Thread.Sleep(700);
                        Console.WriteLine ("You sneaked past the skeleton warrior onto the boss room.");
                        Thread.Sleep(700);
                        Console.WriteLine ("As you entered the boss room the Skeleton Boss immediatly starts the battle" + Environment.NewLine + "Battle Begin!");
                        }
                        Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
                        start_2:
                            int skel_boss = Convert.ToInt32(Console.ReadLine());
                            switch (skel_boss)
                            {
                                case 1:
                                Console.WriteLine ("You attacked it with your sword.");
                                Thread.Sleep(700);
                                Console.WriteLine ("CRITICAL HIT. The boss died in 1-hit.");
                                break;
                                
                                case 2:
                                Console.WriteLine ("Talk");
                                break;
                                
                                case 3: 
                                Console.WriteLine ("Flee");
                                break;
                            }
                            if (skel_boss == 1)
                            {
                            Thread.Sleep (500);
                            Console.WriteLine ("YOU WON CONGRATS!.");
                            }
                            else if (skel_boss == 2)
                            {
                            Console.WriteLine ("Your action was useless againts the boss.");
                            Thread.Sleep (500);
                            Console.WriteLine ("It is now charging an insta-death attack you can't dodge.");
                            Thread.Sleep (500);
                            for (int i = 1; i < 5; i++) 
                            {
                            Console.WriteLine(i + "hahga");
                            }
                            Console.WriteLine ("You have been hit by the death ray. You are dead." + dead);
                            }
                            else if (skel_boss == 3)
                            {
                            Console.WriteLine ("Your action was useless againts the boss.");
                            Thread.Sleep (500);
                            Console.WriteLine ("It is now charging an insta-death attack you can't dodge.");
                            Thread.Sleep (500);
                            for (int i = 1; i < 5; i++) 
                            {
                            Console.WriteLine(i + "hrhghrhgrhhngg");
                            }
                            Console.WriteLine ("You have been hit by the death ray. You are dead." + dead);
                            }
                
                }   
                else if (choice_1 == "No")
                {
                Console.WriteLine ("You died." + dead);
                }
            }
            else if (path == "Left")
            {
            Console.WriteLine ("You decided to go left. You have encountered a chest. Will you open it?" + Environment.NewLine + "Yes or No");
                string choice = Console.ReadLine ();
                if (choice == "Yes")
                {
                Console.WriteLine ("It was a mimic and you were eaten. You have died." + dead);
                }
                else if (choice == "No")
                {
                Console.WriteLine ("You have decided to not open the chest." + line + "\nYou continued your path and discovered the Skeleton boss room.");
                Thread.Sleep(800);
                Console.WriteLine ("As you entered the boss room the Skeleton Boss immediatly starts the battle" + Environment.NewLine + "Battle Begin!");
                Console.WriteLine (line);
                Thread.Sleep (800);
                Console.WriteLine ("Get ready to fight the boss." + Environment.NewLine + "Battle Start!");
                Thread.Sleep(800);
                Console.WriteLine ("The Skeleton boss has 100HP");
                Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
                start_2:
                    int skel_boss = Convert.ToInt32(Console.ReadLine());
                    switch (skel_boss)
                    {
                        case 1:
                        Console.WriteLine ("You attacked it with your sword.");
                        Thread.Sleep(700);
                        Console.WriteLine ("CRITICAL HIT. The boss died in 1-hit.");
                        break;
                                
                        case 2:
                        Console.WriteLine ("Talk");
                        break;
                                
                        case 3: 
                        Console.WriteLine ("Flee");
                        break;
                    }
                            if (skel_boss == 1)
                            {
                            Thread.Sleep (500);
                            Console.WriteLine ("YOU WON CONGRATS!.");
                            }
                            else if (skel_boss == 2)
                            {
                            Console.WriteLine ("Your action was useless againts the boss.");
                            Thread.Sleep (500);
                            Console.WriteLine ("It is now charging an insta-death attack you can't dodge.");
                            Thread.Sleep (500);
                            for (int i = 1; i < 5; i++) 
                            {
                            Console.WriteLine(i + "hahga");
                            }
                            Console.WriteLine ("You have been hit by the death ray. You are dead." + dead);
                            }
                            else if (skel_boss == 3)
                            {
                            Console.WriteLine ("Your action was useless againts the boss.");
                            Thread.Sleep (500);
                            Console.WriteLine ("It is now charging an insta-death attack you can't dodge.");
                            Thread.Sleep (500);
                            for (int i = 1; i < 5; i++) 
                            {
                            Console.WriteLine(i + "hrhghrhgrhhngg");
                            }
                            Console.WriteLine ("You have been hit by the death ray. You are dead." + dead);
                            }
                }
                
                
            }
        }
        
        else if (place == "Dungeon")
        {
        Console.WriteLine (line + Environment.NewLine + "You have decided to go to the " + b);
        Console.WriteLine (dungeon + "\n" + line);
        Thread.Sleep (700);
        Console.WriteLine ("You are inside the dungeon there is a pile of dead bodies in the entrance and there is a goblin looting them." + Environment.NewLine + "Will you Attack or Sneak around?" + Environment.NewLine + line);
        Thread.Sleep (800);
        start_1:
            String d_choice_1 = Console.ReadLine();
            if (d_choice_1 == "Attack")
            {
            Console.WriteLine ("Prepare for battle");
            Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
            int move = Convert.ToInt32(Console.ReadLine());
            switch (move)
            {
                case 1:
                Console.WriteLine ("You attacked it with your sword");
                break;
                        
                case 2:
                Console.WriteLine ("Talk");
                break;
                        
                case 3: 
                Console.WriteLine ("You fleed");
                break;
            }
                    if (move == 1)
                    {
                    Console.WriteLine ("A hored of goblins immediatly came to help their comrade and killed you.\n" + "You died." + dead);
                    }
                    
                    else if (move == 2)
                    {
                    Console.WriteLine ("The goblin was intelligent and said: \n" + "Hello human nice to meet you. I will not attack less you agro." + Environment.NewLine + line);
                    Thread.Sleep (800);
                    Console.WriteLine ("Will you attack still? \n" + "Yes or No");
                    string atk = Console.ReadLine ();
                    if (atk == "Yes")
                    {
                    Console.WriteLine ("A hored of goblins immediatly came to help their comrade and killed you.\n" + "You died." + dead);       
                    }
                    else if (atk == "No")
                    {
                    Console.WriteLine ("The goblin said: \n" + "Wise choice. Then left."); 
                    Thread.Sleep (800);
                    }
                    Console.WriteLine ("You are now exploring the dungeon and felt an ominous aura within a door. \n" + "Will you Enter?" + Environment.NewLine + line);
                    Thread.Sleep (700);
                    Console.WriteLine ("Yes or No");
                    string ent = Console.ReadLine ();
                    if (ent == "Yes")
                    {
                    Console.WriteLine ("It was the room of the Goblin King. \n" + "Prepare for a boss fight");
                    Thread.Sleep (800);
                    Console.WriteLine ("The Goblin King asks you what do you want while sitting in a throne." + Environment.NewLine + line);
                    Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
                    int gboss = Convert.ToInt32(Console.ReadLine());
                    switch (gboss)
                    {
                        case 1:
                        Console.WriteLine ("You attacked it with your sword");
                        break;
                                
                        case 2:
                        Console.WriteLine ("Talk");
                        break;
                                
                        case 3: 
                        Console.WriteLine ("Flee");
                        break;
                    }
                        if (gboss == 1)
                        {
                        Console.WriteLine ("You were too weak to deal damage.\n" + "You died." + dead);
                        }
                        else if (gboss == 2)
                        {
                        Console.WriteLine ("I want treasure to boosts my abilities. You Said.");
                        Thread.Sleep (800);
                        Console.WriteLine ("The Goblin King offers you a potion of immortality." + Environment.NewLine + line);
                        Thread.Sleep (800);
                        Console.WriteLine ("Will you take it? \n" + "Yes or No");
                        string pot = Console.ReadLine ();
                        if (pot == "Yes")
                        {
                        Console.WriteLine ("It was poison. \n" + "You died" + dead);
                        }
                        else if (pot == "No")
                        {
                        Console.WriteLine ("You approached the Goblin King without any plan of partaking in his plan and picked up a silver dagger laying around.");
                        Thread.Sleep (800);
                        Console.WriteLine ("You stabbed the Gobling King with the dagger and killed him. \n" + "You Won!");
                        }
                        }
                        else if (gboss == 3)
                        {
                        Console.WriteLine ("Hordes of goblins went after you due to the Goblin King's order. \n" + "You died" + dead);
                        }
                    }
                    else if (ent == "No")
                    {
                    Console.WriteLine ("You were assasinated by goblin assasins by the Goblin KIng's door. \n" + "You died." + dead);
                    }
                }
            }
        else if (d_choice_1 == "Sneak around")
        {
        Console.WriteLine ("Sneaking around was succesful you are now in the boss room");
        Thread.Sleep (800);
        Console.WriteLine ("It was the room of the Goblin King. \n" + "Prepare for a boss fight");
        Thread.Sleep (800);
        Console.WriteLine ("The Goblin King asks you what do you want while sitting in a throne." + Environment.NewLine + line);
        Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
        int gboss = Convert.ToInt32(Console.ReadLine());
            switch (gboss)
            {
            case 1:
            Console.WriteLine ("You attacked it with your sword");
            break;
                                
            case 2:
            Console.WriteLine ("Talk");
            break;
                                
            case 3: 
            Console.WriteLine ("Flee");
            break;
            }
            if (gboss == 1)
            {
            Console.WriteLine ("You were too weak to deal damage.\n" + "You died." + dead);
            }
        
            else if (gboss == 2)
            {
            Console.WriteLine ("I want treasure to boosts my abilities. You Said." + Environment.NewLine + line);
            Thread.Sleep (800);
            Console.WriteLine ("The Goblin King offers you a potion of immortality.");
            Thread.Sleep (800);
            Console.WriteLine ("Will you take it? \n" + "Yes or No");
            string pot = Console.ReadLine ();
            if (pot == "Yes")
            {
            Console.WriteLine ("It was poison. \n" + "You died" + dead);
            }
            else if (pot == "No")
            {
            Console.WriteLine ("You approached the Goblin King without any plan of partaking in his plan and picked up a silver dagger laying around." + Environment.NewLine + line);
            Thread.Sleep (800);
            Console.WriteLine ("You stabbed the Gobling King with the dagger and killed him. \n" + "You Won!");
            }
            }
            else if (gboss == 3)
            {
            Console.WriteLine ("Hordes of goblins went after you due to the Goblin King's order. \n" + "You died" + dead);
            }
        }
        }
        
        else if (place == "Forest")
        {
        Console.WriteLine (line + Environment.NewLine + "You have decided to go to the " + c + forest + Environment.NewLine + line);
        Thread.Sleep (700);
        Console.WriteLine ("Within the forest, you entered the elves territory. The elves are not friendly to humans and you immediatly entered battle. \nAn elf scout fired an arrow and missed." + Environment.NewLine + line);
        Thread.Sleep (700);
        Console.WriteLine ("Battle Begin");
        Thread.Sleep (700);
        Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
        battle:
            int move = Convert.ToInt32(Console.ReadLine());
            switch (move)
            {
                case 1:
                Console.WriteLine ("You attacked it with your sword.");
                Thread.Sleep(700);
                Console.WriteLine ("The elf died.");
                break;
                        
                case 2:
                Console.WriteLine ("Talk");
                break;
                        
                case 3: 
                Console.WriteLine ("Flee");
                break;
                }
                if (move == 1)
                {
                Console.WriteLine ("You have killed the elf. Took its bow.");   
                Thread.Sleep(1000);
                Console.WriteLine ("The choice you have made started the war of the 2 species. \n" + "You died." + dead);
                }
                else if (move == 2)
                {
                Console.WriteLine ("You talked with the elf and tricked the elf you don't mean harm. \nIt didn't trust you. It fired an arrow and killed you. \n" + "You died." + dead);
                }
                else if (move == 3)
                {
                Console.WriteLine ("You escaped far away from the elves territory." + Environment.NewLine + line);
                Thread.Sleep (800);
                Console.WriteLine ("You are now deep within the forest. \nWhere will you go?" + Environment.NewLine + line);
                Thread.Sleep (800);
                Console.WriteLine ("West or East" + Environment.NewLine + line);
                string der = Console.ReadLine ();
                Thread.Sleep (800);
                if (der == "West")
                {
                Console.WriteLine ("You encountered a dragon." + Environment.NewLine + line);
                Thread.Sleep (800);
                Console.WriteLine ("Prepare for battle");
                Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
                drag:
                int drg = Convert.ToInt32(Console.ReadLine());
                switch (drg)
                {
                    case 1:
                    Console.WriteLine ("You attacked it with your sword.");
                    Thread.Sleep(700);
                    break;
                            
                    case 2:
                    Console.WriteLine ("Talk");
                    break;
                            
                    case 3: 
                    Console.WriteLine ("Flee");
                    break;
                }    
                    if (drg == 1)
                    {
                    Console.WriteLine ("You have wounded the dragon but it fled." + Environment.NewLine + line); 
                    Thread.Sleep (1000);
                    Console.WriteLine ("You are now walking in the deeper parts of the forest.\n" + "There appears to be a huge tree. \n" + "Will you enter?" + Environment.NewLine + line);
                    Thread.Sleep (800);
                    Console.WriteLine ("Yes or No");
                    string tre = Console.ReadLine ();
                    if (tre == "Yes")
                    {
                        Console.WriteLine ("You entered the tree and met the Queen of Elves." + Environment.NewLine + line);
                        Thread.Sleep (700);
                        Console.WriteLine ("The Queen gave you the task of killing the dragon. You accepted");
                        Thread.Sleep (700);
                        Console.WriteLine ("You went and found the dragon you previously wounded. \nPrepare for battle");
                        Console.WriteLine ("1. Attack" + Environment.NewLine + "2. Talk" + Environment.NewLine + "3. Flee");
                        wnd:
                        int dtr = Convert.ToInt32(Console.ReadLine());
                        switch (dtr)
                        {
                            case 1:
                            Console.WriteLine ("You attacked it with your sword.");
                            Thread.Sleep(700);
                            break;
                                    
                            case 2:
                            Console.WriteLine ("Talk");
                            break;
                                    
                            case 3: 
                            Console.WriteLine ("Flee");
                            break;
                        }
                            if (dtr == 1)
                            {
                            Console.WriteLine (line + Environment.NewLine + "You killed the Dragon! The Queen rewarded you with treasures.\nYou Won! ");
                            }
                            
                            else if (dtr == 2)
                            {
                            Console.WriteLine ("The dragon didn't talk back. It fired it's breath at you");
                            for (int i = 1; i < 5; i++) 
                            {
                            Console.WriteLine(i + "HRRRRRHSHHH");
                            }
                            Thread.Sleep (800);
                            Console.WriteLine ("You died" + dead);
                            }
                            
                            else if (dtr == 3)
                            {
                            Console.WriteLine ("You fled but the Dragon killed the Queen of Elves. \n You Lost." + dead);
                            }
                    }
                    else if (tre == "No")
                    {
                    Console.WriteLine ("The Dragon you wounded found you and fired its breath immediatly. \n You died" + dead);
                    }
                    }
                    else if (drg == 2)
                    {
                    Console.WriteLine ("The dragon didn't talk back. It fired it's breath at you");
                    for (int i = 1; i < 5; i++) 
                    {
                    Console.WriteLine(i + "HRRRRRHSHHH");
                    }
                    Thread.Sleep (800);
                    Console.WriteLine ("You died" + dead);
                    }
                    else if (drg == 3)
                    {
                    Console.WriteLine ("You can't outrun a dragon with wings.\n" + "You died" + dead);
                    }
                }
                
                else if (der == "East")
                {
                Console.WriteLine ("You went East. \n" + line);
                Thread.Sleep (800);
                Console.WriteLine ("You found you way back to the outside of the forest. \nYou survived but didn't get any from that adventure." + Environment.NewLine + line);
                }
                }
        
        }
    }
}

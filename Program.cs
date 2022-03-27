using System;

class MainClass
{
    private static Random RNG = new Random();

    public static void Main(string[] args)
    {
    /*
     * Generate two Characters P1 and P2
     */
    PlayerCharacter P1 = new PlayerCharacter("Zavier", 18, 11, 17, 15, 14, 13);
        PlayerCharacter P2 = new PlayerCharacter("Chris");

        /*
         * Print out their stats
         */

        System.Console.WriteLine(P1.CharacterSheet());
        System.Console.WriteLine(P2.CharacterSheet());

        /*
        * Menu-System for attacking one another
        * Fight to the mostly dead
        */

        System.Console.WriteLine($"Before the fight, {P1.Name} has {P1.Health} HP, and " +
                                  $"{P2.Name} has {P2.Health} HP.");
        /*while (P1.isAlive() && P2.isAlive())
        {
            //System.Console.WriteLine("Menu of Choices");
            System.Console.WriteLine(P1.Tackle(P2));
            System.Console.WriteLine(P2.Tackle(P1));
        }

        if (!P1.isAlive())
        {
            System.Console.WriteLine(P1.Name + " RIP!!!");
        }
        if (!P2.isAlive())
        {
            System.Console.WriteLine(P2.Name + " RIP!!!");
        }*/

        
        while (P1.isAlive() && P2.isAlive())
        {
            char attack = '0';
            string label = "";
            string[] playerAttack = new string[] {"Tackle", "Stone", "Pummel"};
            System.Console.WriteLine("Menu of Choices:");
            System.Console.WriteLine("1: Tackle");
            System.Console.WriteLine("2: Stone");
            System.Console.WriteLine("3: Pummel");
            System.Console.Write("Choose your method of attack: ");
            while (attack < '1' || attack > '3')
            {
                attack = (System.Console.ReadLine()).ToCharArray()[0];
                int index = RNG.Next(playerAttack.Length);



                if (attack == '1' && index == 0)
                {
                    label = "Tackle";
                    System.Console.WriteLine($"You chose to {label} your opponent.");
                    System.Console.WriteLine($"Your opponent chose to {playerAttack[index]} you.");
                    System.Console.WriteLine(P1.Tackle(P2));
                    System.Console.WriteLine(P2.Tackle(P1));
                }
                else if (attack == '1' && index == 1)
                {
                    label = "Tackle";
                    System.Console.WriteLine($"You chose to {label} your opponent.");
                    System.Console.WriteLine($"Your opponent chose to {playerAttack[index]} you.");
                    System.Console.WriteLine(P1.Tackle(P2));
                    System.Console.WriteLine(P2.Stone(P1));
                }
                else if (attack == '1' && index == 2)
                {
                    label = "Tackle";
                    System.Console.WriteLine($"You chose to {label} your opponent.");
                    System.Console.WriteLine($"Your opponent chose to {playerAttack[index]} you.");
                    System.Console.WriteLine(P1.Tackle(P2));
                    System.Console.WriteLine(P2.Pummel(P1));
                }
                else if (attack == '2' && index == 0)
                {
                    label = "Stone";
                    System.Console.WriteLine($"You chose to {label} your opponent.");
                    System.Console.WriteLine($"Your opponent chose to {playerAttack[index]} you.");
                    System.Console.WriteLine(P1.Stone(P2));
                    System.Console.WriteLine(P2.Tackle(P1));

                }
                else if (attack == '2' && index == 1)
                {
                    label = "Stone";
                    System.Console.WriteLine($"You chose to {label} your opponent.");
                    System.Console.WriteLine($"Your opponent chose to {playerAttack[index]} you.");
                    System.Console.WriteLine(P1.Stone(P2));
                    System.Console.WriteLine(P2.Stone(P1));
                }
                else if (attack == '2' && index == 2)
                {
                    label = "Stone";
                    System.Console.WriteLine($"You chose to {label} your opponent.");
                    System.Console.WriteLine($"Your opponent chose to {playerAttack[index]} you.");
                    System.Console.WriteLine(P1.Stone(P2));
                    System.Console.WriteLine(P2.Pummel(P1));
                }
                else if (attack == '3' && index == 0)
                {
                    label = "Pummel";
                    System.Console.WriteLine($"You chose to {label} your opponent.");
                    System.Console.WriteLine($"Your opponent chose to {playerAttack[index]} you.");
                    System.Console.WriteLine(P1.Pummel(P2));
                    System.Console.WriteLine(P2.Tackle(P1));
                }
                else if (attack == '3' && index == 1)
                {
                    label = "Tackle";
                    System.Console.WriteLine($"You chose to {label} your opponent.");
                    System.Console.WriteLine($"Your opponent chose to {playerAttack[index]} you.");
                    System.Console.WriteLine(P1.Pummel(P2));
                    System.Console.WriteLine(P2.Stone(P1));
                }
                else
                {
                    label = "Pummel";
                    System.Console.WriteLine($"You chose to {label} your opponent.");
                    System.Console.WriteLine($"Your opponent chose to {playerAttack[index]} you.");
                    System.Console.WriteLine(P1.Pummel(P2));
                    System.Console.WriteLine(P2.Pummel(P1));
                }
            }
        }

        if (!P1.isAlive())
        {
            System.Console.WriteLine(P1.Name + " RIP!!!");
        }
        if (!P2.isAlive())
        {
            System.Console.WriteLine(P2.Name + " RIP!!!");
        }


    }

}

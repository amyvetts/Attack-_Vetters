using System;
using System.Linq;

class PlayerCharacter
{

    /* static field */
    private static Random RNG = new Random();

    /* Member Data "fields" */
    private int[] attributes;

    /* Member Data "properties" */
    public string Name { get; set; }
    public int Age { get; set; }
    public int Health { get; private set; }
    public int Strength
    {
        get
        {
            return attributes[0];
        }

        private set
        {
            attributes[0] = value;
        }
    }

    public int Dexterity
    {
        get
        {
            return attributes[1];
        }

        private set
        {
            attributes[1] = value;
        }
    }

    public int Constitution
    {
        get
        {
            return attributes[2];
        }

        private set
        {
            attributes[2] = value;
        }
    }

    public int Intelligence
    {
        get
        {
            return attributes[3];
        }

        private set
        {
            attributes[3] = value;
        }
    }

    public int Wisdom
    {
        get
        {
            return attributes[4];
        }

        private set
        {
            attributes[4] = value;
        }
    }

    public int Charisma
    {
        get
        {
            return attributes[5];
        }

        private set
        {
            attributes[5] = value;
        }
    }

    // constructors

    //default constructor
    public PlayerCharacter()
    {
        this.Name = "";    // default name
        this.Age = RNG.Next(80) + 11;   // 11-90 range default
        this.attributes = new int[6];
        for (int attribute = 0; attribute < this.attributes.Length; attribute++)
        {
            int[] dice = new int[4];
            for (int die = 0; die < dice.Length; die++)
            {
                dice[die] = RNG.Next(6) + 1;
            }
            this.attributes[attribute] = dice.Sum() - dice.Min();
        }

        this.Health = 10 + (this.Constitution - 10) / 2;
    }

    public PlayerCharacter(string Name) : this()
    {
        this.Name = Name;
    }

    public PlayerCharacter(string Name,
                           int s,
                           int d,
                           int cn,
                           int i,
                           int w,
                           int ch) : this(Name)
    {
        this.Strength = s;
        this.Dexterity = d;
        this.Constitution = cn;
        this.Intelligence = i;
        this.Wisdom = w;
        this.Charisma = ch;

        this.Health = 10 + (this.Constitution - 10) / 2;
    }

    // methods

    /*
    In C#, we will use properties instead of accessor
    and mutator methods.

    //accessor methods (getters)
    public int getHealth() {
      return Health;
    }

    //mutator methods (setters)
    public void setHealth(int newHealth) {
      Health = newHealth;
    }
    */

    public string CharacterSheet()
    {
        string sheet = "";
        sheet += "===================================\n";
        sheet += $"Name: {this.Name}\t\tAge: {this.Age}\n";  // sheet +=  is same as   sheet = sheet +
        sheet += "-----------------------------------\n";
        sheet += $"\tSTR: {this.Strength}\n";
        sheet += $"\tDEX: {this.Dexterity}\n";
        sheet += $"\tCON: {this.Constitution}\n";
        sheet += $"\tINT: {this.Intelligence}\n";
        sheet += $"\tWIS: {this.Wisdom}\n";
        sheet += $"\tCHR: {this.Charisma}\n";
        sheet += "-----------------------------------\n";
        sheet += $"Health: {this.Health}\n";
        sheet += "===================================\n";
        return sheet;
    }

    public bool isAlive()
    {
        return (Health > 0);
    }

    public string Tackle(PlayerCharacter defender)
    {
        string combatDescription = "";
        // probability to hit
        if (RNG.Next(20) + 1 > defender.Dexterity)
        {
            //you hit!
            // randomize the damage 
            int damageDone = (RNG.Next(4) + 1 + (this.Strength - 10) / 2);
            damageDone = Math.Max(damageDone, 1);
            combatDescription = $"{this.Name}[{this.Health}] tackles {defender.Name}[{defender.Health}] for {damageDone} damage!";
            defender.Health = defender.Health - damageDone;
        }
        else
        {
            //you miss!
            combatDescription = $"{this.Name}[{this.Health}] tries to tackle {defender.Name}[{defender.Health}] and misses!";
        }
        // give the returned message more detail
        return combatDescription;
    }
    public string Stone(PlayerCharacter defender)
    {
        string combatDesc = "";
        if(RNG.Next(20) + 1 > defender.Intelligence)
        {
            //hit
            int damage = (RNG.Next(4) + 1+ (this.Strength - 10) / 2) ;
            damage = Math.Max(damage, 3);
            combatDesc = $"{this.Name}[{this.Health}] stones {defender.Name}[{defender.Health}] for {damage} damage!";
            defender.Health = defender.Health - damage;
        }
        else
        {
            combatDesc = $"{this.Name}[{this.Health}] tries to stone {defender.Name}[{defender.Health}] and misses!";
        }
        return combatDesc;
    }

    public string Pummel(PlayerCharacter defender)
    {
        string combatDescript = "";
        if (RNG.Next(20) + 1 > defender.Wisdom)
        {
            //hit
            int damage = (RNG.Next(4) + 1 + (this.Strength - 10) / 2);
            damage = Math.Max(damage, 4);
            combatDescript = $"{this.Name}[{this.Health}] pummels {defender.Name}[{defender.Health}] for {damage} damage!";
            defender.Health = defender.Health - damage;
        }
        else
        {
            combatDescript = $"{this.Name}[{this.Health}] tries to pummel {defender.Name}[{defender.Health}] and misses!";
        }
        return combatDescript;
    }
    
    
}
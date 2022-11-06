public abstract class Character
{
  //properties
  public string Name { get; set; }
  public int Attack { get; set; } = 10;
  public int Defense { get; set; } = 10;
  public int Speed { get; set; } = 10;
  public int HP { get; set; } = 20;
  public bool IsAlive { get; set; } = true;
  public bool IsBlocking { get; set; } = false;
  public Room CurrentRoom {get;set;}
  //constructor

  //methods
  public void DisplayStats()
  {
    System.Console.WriteLine($"Attack={Attack},Defense={Defense}, Speed={Speed}");
  }

  public void PerformAttack(Character Recipient) {
    Random rng = new Random();
    int diceRoll = rng.Next(1,21);
    // for every 2 points above an 8 in the Attack stat, a +1 modifier is added to the diceroll
    int attackRoll = (Attack-8)/2 + diceRoll;
    // an attack roll has to equal or exceed the opponent's speed stat to successfully deal damage
    if (attackRoll >= Recipient.Speed) {
      // 
      int damageDealt = Math.Max(2,Attack - Recipient.Defense);
      Recipient.HP -= damageDealt;
      System.Console.WriteLine($"{Name} attacks, dealing {damageDealt} damage to {Recipient.Name}");
    } else {
      System.Console.WriteLine($"{Name} attacks, and just barely missed {Recipient.Name}!");
    }
    System.Console.WriteLine($"{Recipient.Name} has {Recipient.HP} HP remaining");
  }

  public void PerformBlocking() {
    IsBlocking = true;
    Defense += 3;
    Speed+=3;
    System.Console.WriteLine($"{Name} prepares to block, bracing for an oncoming attack...");
  }

  public void EndBlocking() {
    IsBlocking = false;
    Defense -= 3;
    Speed -= 3;
  }

  public void CheckIsAlive() {
    if (HP <= 0) {
      IsAlive = false;
      System.Console.WriteLine($"{Name} has died.");
    }
  }
 
}

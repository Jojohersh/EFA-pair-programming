public abstract class Character
{
  //properties
  //name, stats, attack1, attack2
  public string Name { get; set; }
  public int Attack { get; set; } = 10;
  public int Defense { get; set; } = 10;
  public int Speed { get; set; } = 10;
  public int HP { get; set; } = 50;
  public bool IsAlive { get; set; } = true;
  public bool IsBlocking { get; set; } = false;
  //constructor

  //methods
  public void DisplayStats()
  {
    System.Console.WriteLine($"Attack={Attack},Defense={Defense}, Speed={Speed}");
  }

  public void PerformAttack(Character Recipient) {
    Random rng = new Random();
    int diceRoll = rng.Next(1,21);
    int attackRoll = (Attack-8)/2 + diceRoll;
    if (attackRoll >= Recipient.Speed) {
      int damageDealt = Math.Max(2,Attack - Recipient.Defense);
      Recipient.HP -= damageDealt;
      System.Console.WriteLine($"{Name} dealt {damageDealt} damage to {Recipient.Name}");
    } else {
      System.Console.WriteLine($"{Name} just barely missed {Recipient.Name}!");
    }
    System.Console.WriteLine($"{Recipient.Name} has {Recipient.HP} HP remaining");
  }

  public void PerformBlocking() {
    IsBlocking = true;
    Defense += 3;
    Speed+=3;
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

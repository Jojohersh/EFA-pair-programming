
public class Goblin : Monster
{
    public Goblin()
    {
        Name="Generic Goblin";
        Attack=8;
        Defense=6;
        Speed=15;
        HP=20;
        System.Console.WriteLine($"Goblin:{Name}");
        DisplayStats();
    }
}

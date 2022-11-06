
    public class Human : Character
    {
        public Human()
        {
            System.Console.WriteLine("Hello human, what is your name?");
            Name = System.Console.ReadLine();
            System.Console.WriteLine($"Pleased to meet you, {Name}.");
            IsAlive = true;
            Attack = 12;
            Defense = 12;
            Speed = 12;
            // DisplayStats();
        }
    }

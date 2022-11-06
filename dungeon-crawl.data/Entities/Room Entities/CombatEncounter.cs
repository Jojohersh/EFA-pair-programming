
    public class CombatEncounter : Encounter
    {
        public Character Player { get; set; }
        public Character Enemy {get; set;}
        public CombatEncounter(Character player, Character enemy)
        {
            Player = player;
            Enemy = enemy;
        }
        public static bool RunCombat(Character player,Character enemy) {
            System.Console.WriteLine($"\n{player.Name} has to fight {enemy.Name}\n");
            // begin combat loop
            while (player.IsAlive && enemy.IsAlive) {
                System.Console.WriteLine("What would you like to do?\n1. Attack\n2. Block");
                // prompt user to either attack or defend
                string userChoice = System.Console.ReadLine();
                switch (userChoice) {
                    case "1":
                        player.PerformAttack(enemy);
                        break;
                    case "2":
                        player.PerformBlocking();
                        break;
                    default:
                        System.Console.WriteLine("Invalid selection, you do nothing this round.");
                        break;
                }
                // randomly select whether enemy attacks or blocks
                Random rng = new Random();
                int EnemyChoice = rng.Next(1,3);
                switch (EnemyChoice) {
                    case 1:
                        enemy.PerformAttack(player);
                        break;
                    case 2:
                        enemy.PerformBlocking();
                        break;
                    default:
                        System.Console.WriteLine("Invalid selection, you do nothing this round.");
                        break;
                }
                player.EndBlocking();
                enemy.EndBlocking();
                // check if player or enemy died
                player.CheckIsAlive();
                enemy.CheckIsAlive();
            }
            if (player.IsAlive) {
                return true;
            } else {
                return false;
            }
        }
        public override void StartEncounter() {
            Succeeded = RunCombat(Player, Enemy);
            if (Succeeded) {
                System.Console.WriteLine($"{Player.Name} defeated {Enemy.Name}!");
            } else {
                System.Console.WriteLine("You died. GAME OVER.");
            }
        }
    }

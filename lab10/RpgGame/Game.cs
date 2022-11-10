using RpgGame.Generators;

namespace RpgGame
{
    public class Game {

        public static Random Random {get;} = new Random();

        private MonsterGenerator _monsterGenerator = new MonsterGenerator();

        public Player Player {get; set;}

        public Monster Monster {get;set;}

        public int KillCount {get;set;}

        public static Queue<string> Messages {get; private set;} = new Queue<string>();

        public void Run(){

            Initialize();
            
            Render();
            while(true){
                HandleInput(); Update();
                Render();
            }
        }

        private void Initialize()
        {

            Player = new Player();

            Monster = _monsterGenerator.Generate();
            Monster.Name = "Steve";
        }

        private void Render()
        {
            Console.Clear();
            Console.WriteLine($"Oponent: {Monster.Name}");
            Console.WriteLine($"Monster hitpoints: {Monster.HitPoints}");
            Console.WriteLine();
            Console.WriteLine($"Player: {Player.HitPoints}/{Player.MaxHitPoints}");

            Console.WriteLine("A - Attack");
            Console.WriteLine("D - Defense");

            Console.WriteLine("Combat log:");
            foreach (var msg in Messages)
            {
                Console.WriteLine(msg);
            }
        }

        private void Update()
        {
        

            if(Monster.HitPoints < 0){
                Messages.Enqueue($"You killed the monster {Monster.Name}!");

                KillCount++;
                Monster = _monsterGenerator.Generate();
                Messages.Enqueue("New monster enters stage");
            }

            if(KillCount>=3){
                Console.WriteLine("You killed the army of monster!"); 
                Console.WriteLine("You Won!!!");
                Environment.Exit(0);
            }

            Monster.Attack(Player);

            if(Player.HitPoints < 0){
                Console.WriteLine("You are dead!");
                Environment.Exit(0);
            }


            while (Messages.Count>5){
                Messages.Dequeue();
            }
        }

        private void HandleInput()
        {
            var key = Console.ReadKey(true);

            if(key.Key == ConsoleKey.A){
                Player.Attack(Monster);
            } else if(key.Key == ConsoleKey.D){
                Player.ActivateDefense();
            }
        }
    }
}
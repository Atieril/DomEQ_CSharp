using RpgGame.Generators;

namespace RpgGame
{
    public class Game {

        public static Random Random {get;} = new Random();

        private MonsterGenerator _monsterGenerator = new MonsterGenerator();

        public Player Player {get; set;}

        public Map Map {get;set;} 

        public MapRenderer Renderer {get;set;}


        public int KillCount {get;set;}

        public static Queue<string> Messages {get; private set;} = new Queue<string>();

        public Game()
        {
            Initialize();
        }

        public void Run(){
            Render();
            while(true){
                HandleInput(); Update();
                Render();
            }
        }

        private void Initialize()
        {

            Player = new Player();

            Map = new Map(50,50);
            Map.Player = Player;
            
            Map.Characters.Add(Player);

            for(var i = 0;i<10;i++){
                var monster = _monsterGenerator.Generate();
                monster.Position = new Coordinates(Game.Random.Next(0,Map.Width),Game.Random.Next(0,Map.Height));
                Map.Characters.Add(monster);
            }

            Renderer = new MapRenderer(6);

    
        }

        private void Render()
        {
            Console.Clear();

            Renderer.Render(Map,Player.Position.X,Player.Position.Y);

            // Console.WriteLine($"Oponent: {Monster.Name}");
            // Console.WriteLine($"Monster hitpoints: {Monster.HitPoints}");
            // Console.WriteLine();
            Console.WriteLine($"Player: {Player.HitPoints}/{Player.MaxHitPoints}");
            Console.WriteLine("Combat log:");
            foreach (var msg in Messages)
            {
                Console.WriteLine(msg);
            }
        }

        private void Update()
        {


            

/*
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
            */

            while (Messages.Count>5){
                Messages.Dequeue();
            }
        }

        private void HandleInput()
        {
            var key = Console.ReadKey(true);

            switch(key.Key){
                case ConsoleKey.UpArrow:
                    Map.TryMoveCharacter(0,-1,Player);
                    break;
            case ConsoleKey.DownArrow:
                    Map.TryMoveCharacter(0,1,Player);
                    break;
            case ConsoleKey.LeftArrow:
                    Map.TryMoveCharacter(-1,0,Player);
                    break;
            case ConsoleKey.RightArrow:
                    Map.TryMoveCharacter(1,0,Player);
                    break;
            }

            if(key.Key == ConsoleKey.UpArrow){

            }
            // if(key.Key == ConsoleKey.A){
            //     Player.Attack(Monster);
            // } else if(key.Key == ConsoleKey.D){
            //     Player.ActivateDefense();
            // }
        }
    }

}
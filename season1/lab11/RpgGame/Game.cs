using RpgGame.Generators;

namespace RpgGame
{
    public class Game {

        public int Time {get;private set;}
        public bool IsRunning {get;set;} = true;

        public Random Random {get;} = new Random();

        public Player Player {get; set;}

        public Map Map {get;set;} 

        private Queue<string> _messages = new Queue<string>();
        private readonly MonsterGenerator _monsterGenerator;
        private readonly MapRenderer _renderer;

        public Game()
        {
            Player = new Player(this);
            _monsterGenerator = new MonsterGenerator(this);
            Map = new Map(50,50,Player);
            Map.Characters.Add(Player);
            for(var i = 0;i<250;i++){
                var monster = _monsterGenerator.Generate();
                monster.Position = new Coordinates(Random.Next(0,Map.Width),Random.Next(0,Map.Height));
                Map.Characters.Add(monster);
            }

            _renderer = new MapRenderer(6);
        }

        public void Run(){
            Render();
            var startTime = DateTime.Now;
            while(IsRunning){
                HandleInput();
                Update();
                Render();
            }
            var endTime = DateTime.Now;
            Console.WriteLine($"Moves: {Time}");
            Console.WriteLine($"Your time: {(endTime-startTime)}");
        }

        private void Render()
        {
            Console.Clear();

            _renderer.Render(Map,Player.Position.X,Player.Position.Y);

            Console.WriteLine($"Player: {Player.HitPoints}/{Player.MaxHitPoints} Kill Count: {Player.KillCount}");
            Console.WriteLine("Combat log:");
            foreach (var msg in _messages)
            {
                Console.WriteLine(msg);
            }
        }

        private void Update()
        {
            Time++;
            foreach(var character in Map.Characters){
                var move = character.GetMove();
                Map.TryMoveCharacter(move.X,move.Y,character);
            }

            if(Player.KillCount>=3){
                AddMessage("You won!!!");
                IsRunning = false;
            }
        }

        private void HandleInput()
        {
            var turnLength = 500;
            
            DateTime start = DateTime.Now;

            do{
                Thread.Sleep(10);
                if(Console.KeyAvailable){
                    break;
                }
            } while((DateTime.Now - start).TotalMilliseconds < turnLength);

                if(!Console.KeyAvailable){
                    return;
                }

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
        }

        public void AddMessage(string message){
            _messages.Enqueue(message);
            while (_messages.Count>5){
                _messages.Dequeue();
            }
        }
    }

}
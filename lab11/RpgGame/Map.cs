namespace RpgGame
{
    public class Map{
        
        public Player Player {get;set;}

        public int Width {get;}
        public int Height {get;}

        public MapElement[,] Fields {get;set;}

        public List<GameCharacter> Characters {get;} = new List<GameCharacter>();

        public Map(int width, int height,Player player)
        {
            Player = player;
            Width = width;
            Height = height;

            Fields = new MapElement[width,height];

        }

        internal bool TryMoveCharacter(int x, int y, Player player)
        {
            var destinationX = player.Position.X+x;
            var destinationY = player.Position.Y+y;

            if(destinationX <0 || destinationX >= Width || destinationY <0 || destinationY >= Height){
                return false;
            }

            foreach(var character in Characters){
                if(character.Position.X == destinationX && character.Position.Y == destinationY && player != character) {
                    var monster = (Monster)character;
                    player.Attack(monster);
                    if(monster.HitPoints<0){
                        Game.Messages.Enqueue($"You killed {monster.Name}");
                        Characters.Remove(monster);
                    }
                    return false;

                }
            }
            
            var targetElement = Fields[destinationX,destinationY];

            if(IsWalkable(targetElement)){
                player.Position.X = destinationX;
                player.Position.Y = destinationY;
                return true;
            }

            return false;
        }

        private bool IsWalkable(MapElement element){
            if (element == MapElement.Empty)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
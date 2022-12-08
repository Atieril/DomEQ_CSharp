namespace RpgGame
{
    public class Map
    {
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

        internal bool TryMoveCharacter(int x, int y, GameCharacter movingCharacter)
        {
            var destinationX = movingCharacter.Position.X+x;
            var destinationY = movingCharacter.Position.Y+y;

            if(destinationX <0 || destinationX >= Width || destinationY <0 || destinationY >= Height){
                return false;
            }

            var toRemove = new List<GameCharacter>();

            foreach(var targetCharacter in Characters){
                if(targetCharacter.Position.X == destinationX && targetCharacter.Position.Y == destinationY && movingCharacter != targetCharacter) {
                    

                    movingCharacter.Attack(targetCharacter);
                    if(targetCharacter.HitPoints<0){
                        
                        targetCharacter.Kill();
                        movingCharacter.OnKill(targetCharacter);

                        
                        toRemove.Add(targetCharacter);
                    }
                    return false;

                }
            }

            foreach(var character in toRemove){
                Characters.Remove(character);
            }
            
            var targetElement = Fields[destinationX,destinationY];

            if(IsWalkable(targetElement)){
                movingCharacter.Position.X = destinationX;
                movingCharacter.Position.Y = destinationY;
                return true;
            }

            return false;
        }

        private bool IsWalkable(MapElement element)
        {
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
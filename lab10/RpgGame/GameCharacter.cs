namespace RpgGame
{
    public abstract class GameCharacter{
        public Coordinates Position {get;set;}

        public abstract string GetSign();
    }
}
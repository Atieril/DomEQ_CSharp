namespace RpgGame
{
    public abstract class GameCharacter{

        public Coordinates Position {get;set;} = new Coordinates(0,0);
        public int HitPoints {get; set;} 

        public abstract string GetSign();
    }
}
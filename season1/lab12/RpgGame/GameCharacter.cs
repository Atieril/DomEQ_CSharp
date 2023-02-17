namespace RpgGame
{
    public abstract class GameCharacter{
        public Game Game { get; }

        public GameCharacter(Game game)
        {
            Game = game;
        }

        public Coordinates Position {get;set;} = new Coordinates(0,0);
        public int HitPoints {get; set;} 
        public int MaxHitPoints {get;set;}

        public bool IsDead => HitPoints<=0; 

        public abstract string GetSign();

        public abstract void Attack(GameCharacter other);
        public abstract void TakeDamage(int damage);

        public virtual Coordinates GetMove(){
            return new Coordinates(0,0);
        }

        public abstract void Kill();

        public virtual void OnKill(GameCharacter victim){

        }
    }
}
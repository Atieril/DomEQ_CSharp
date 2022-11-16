namespace RpgGame
{
    public class Monster : GameCharacter{

        public string Sign => Name[0].ToString().ToLower();

        public string Name {get;set;}
         public int HitPoints {get;set;}

        public void Attack(Player player){
            player.TakeDamage(Game.Random.Next(3,7));
        }

        public Coordinates GetMove(){
            return new Coordinates(Game.Random.Next(-1,2),Game.Random.Next(-1,2));
        }

        public override string GetSign()
        {
            return Sign;
        }
    }
}
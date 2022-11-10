namespace RpgGame
{
    public class Monster{

        public string Name {get;set;}
         public int HitPoints {get;set;}

        public void Attack(Player player){
            player.TakeDamage(Game.Random.Next(3,7));
        }

    }
}
namespace RpgGame
{
    public class Player{
        public int HitPoints {get; private set;} = 100;
        public int MaxHitPoints {get;set;} = 100;

        public bool IsInDefense {get; private set;}

        public void Attack(Monster monster){
            var damage = Game.Random.Next(3,10);
            monster.HitPoints -= damage;
            Game.Messages.Enqueue($"You deal {damage} damage");
        }

        public void TakeDamage(int damage){

            if(IsInDefense){
               HitPoints -= damage/2;   
               Game.Messages.Enqueue($"You've taken {damage/2} damage");
               IsInDefense=false;
               var heal = Game.Random.Next(3,7);
               HitPoints += heal;
               Game.Messages.Enqueue($"You've healed {heal}");
            } else {
                HitPoints -= damage;
                Game.Messages.Enqueue($"You've taken {damage} damage");
            }
            
        }

        public void ActivateDefense()
        {
            IsInDefense = true;
        }
    }
}
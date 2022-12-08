namespace RpgGame
{
    public class Player : GameCharacter{

        public Player(Game game) : base(game)
        {
            Position = new Coordinates(3,3);
            MaxHitPoints = 100;
            HitPoints = MaxHitPoints;
        }

        public int KillCount {get; private set;} = 0;

        public bool IsInDefense {get; private set;}
        

        public override void Attack(GameCharacter opponent){
            var damage = Game.Random.Next(3,10);
            opponent.TakeDamage(damage);
        }

        public override void TakeDamage(int damage){

            if(IsInDefense){
               HitPoints -= damage/2;   
               Game.AddMessage($"You've taken {damage/2} damage");
               IsInDefense=false;
               var heal = Game.Random.Next(3,7);
               HitPoints += heal;
               Game.AddMessage($"You've healed {heal}");
            } else {
                HitPoints -= damage;
                Game.AddMessage($"You've taken {damage} damage");
            }
            
        }

        public void ActivateDefense()
        {
            IsInDefense = true;
        }

        public override string GetSign()
        {
            return "@";
        }

        public override void Kill()
        {
            Game.AddMessage($"You Died!!!");
            Game.IsRunning = false;
        }

        public override void OnKill(GameCharacter victim)
        {
            base.OnKill(victim);
            KillCount++;
        }
    }
}
namespace RpgGame
{
    public class Monster : GameCharacter{
        public Monster(Game game) : base(game)
        {
        }

        public string Sign => Name[0].ToString().ToLower();

        public string Name {get;set;} = "";
         
        public override void Attack(GameCharacter opponent){
            var damage = Game.Random.Next(3,7);
            opponent.TakeDamage(damage);
        }

        public override Coordinates GetMove(){
            return new Coordinates(Game.Random.Next(-1,2),Game.Random.Next(-1,2));
        }

        public override string GetSign()
        {
            return Sign;
        }

        public override void Kill()
        {
            Game.AddMessage($"Monster {Name} dies");
        }

        public override void TakeDamage(int damage)
        {
            HitPoints -= damage;
            Game.AddMessage($"Monster {Name} took {damage} damage");
        }
    }
}
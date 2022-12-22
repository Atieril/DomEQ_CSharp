namespace RpgGame.Generators
{
    public class MonsterGenerator {

        private string[] _monsterNames = {"Steve", "Bob","John"};
        private readonly Game _game;

        public MonsterGenerator(Game game)
        {
            _game = game;
        }
        
        public Monster Generate(){
            var monster = new Monster(_game);
            monster.HitPoints =_game.Random.Next(40,60);
            monster.Name = _monsterNames[_game.Random.Next(_monsterNames.Length)];

            return monster;

        }
    }
}
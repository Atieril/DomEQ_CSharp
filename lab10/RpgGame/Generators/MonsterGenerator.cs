namespace RpgGame.Generators
{
    public class MonsterGenerator {

        private string[] _monsterNames = {"Steve", "Bob","John"};

        public Monster Generate(){
            var monster = new Monster();
            monster.HitPoints =Game.Random.Next(40,60);
            monster.Name = _monsterNames[Game.Random.Next(_monsterNames.Length)];

            return monster;

        }



    }
}
namespace RpgGame
{
    public class MapRenderer {

        public int Radius { get; }

        public MapRenderer(int radius)
        {
            Radius = radius;
        }

        public void Render(Map map,int x, int y)
        {
            var startX = x-Radius;
            var startY = y-Radius;
            var endX = x+Radius;
            var endY = y+Radius;

            for(var py = startY;py<=endY;py++){
                for(var px = startX;px<=endX;px++){
                    if (px<0 || py <0 || px>=map.Width || py>= map.Height){
                        Console.Write(" ");
                        continue;
                    }

                    var isCharacterInSpot = false;
                    foreach(var character in map.Characters){
                        if(px == character.Position.X && py == character.Position.Y){
                            Console.Write(character.GetSign());
                            isCharacterInSpot = true;
                            break;
                        }
                    }
                    if(isCharacterInSpot){
                        continue;
                    }

                    var field = map.Fields[px,py];
                    switch(field)
                    {
                        case MapElement.Empty:
                            Console.Write(".");
                            break;
                        case MapElement.Wall:
                            Console.Write("#");
                                break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
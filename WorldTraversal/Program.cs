namespace WorldTraversal
{
    internal class Program
    {
       private readonly static Random random = new Random();
       
        static void Main(string[] args)
        {
            var world = new World();
            var player = new Player(world);
            var currentPosition = player.GetPosition();
            Console.WriteLine(currentPosition.getCoords());
            MakeRandomMove(player);
            Console.WriteLine(currentPosition.getCoords());
        }

        public static void MakeRandomMove(Player player)
        {
            int randomDirection = random.Next(4);

            switch(randomDirection)
            {
                case 0:
                    player.GetPosition().moveLeft();
                    break;
                case 1:
                    player.GetPosition().moveRight(); 
                    break;
                case 2:
                    player.GetPosition().moveUp();
                    break;
                case 3:
                    player.GetPosition().moveDown();
                    break;
            }
        }
    }
}
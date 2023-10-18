namespace WorldTraversal
{
    public class Player
    {
        private readonly Random _random = new Random();
        private Position _position;

        public Player(World world)
        {
            List<Position> worldPositions = world.GetPositions();
            int randomIndex = _random.Next(worldPositions.Count);
            _position = worldPositions[randomIndex];
        }

        public Position GetPosition()
        {
            return _position;
        }
    }
}
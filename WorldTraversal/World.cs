namespace WorldTraversal
{
    public class World
    {
        private Dictionary<Position, string> _positionsWithObjects;

        public World()
        {
            _positionsWithObjects = new Dictionary<Position, string>();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    _positionsWithObjects.Add(new Position(i, j), null);
                }
            }

            PlaceObject(new Position(5, 4), "Apple");
        }

        public List<Position> GetPositions()
        {
            return new List<Position>(_positionsWithObjects.Keys);
        }

        public string GetObjectAtPosition(Position position)
        {
            if (_positionsWithObjects.ContainsKey(position))
            {
                return _positionsWithObjects[position];
            }
            return null;
        }

        public void PlaceObject(Position position, string objectName)
        {
            if (_positionsWithObjects.ContainsKey(position))
            {
                _positionsWithObjects[position] = objectName;
            }
        }
    }
}
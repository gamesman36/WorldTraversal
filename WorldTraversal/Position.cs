namespace WorldTraversal
{
    public class Position
    {
        private int _xValue;
        private int _yValue;

        public Position(int xValue, int yValue)
        {
            _xValue = xValue;
            _yValue = yValue;
        }

        public void moveLeft()
        {
            if(_xValue > 1) _xValue--;
        }

        public void moveRight()
        {
            if(_xValue < 10) _xValue++;
        }

        public void moveUp()
        {
            if(_yValue < 10) _yValue++;
        }

        public void moveDown()
        {
            if (_yValue > 1) _yValue--;
        }

        public (int, int) getCoords()
        {
            return (_xValue, _yValue);
        }
    }
}
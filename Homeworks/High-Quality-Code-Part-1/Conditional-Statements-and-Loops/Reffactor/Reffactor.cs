namespace Reffactor
{
    class Reffactor
    {
        private Potato potato;
        //... 

        private void SomeMethod()
        {
            var isPeeled = ...
            var isRotten = ...

            if (potato != null)
            {
                if (!isPeeled && !isRooten)
                {
                    Cook(potato);
                }
            }
        }

        // Other if of task

        private void VisitValidCell(int x, int y)
        {
            const int MIN_X = 0;
            const int MIN_Y = 0;

            const int MAX_X = 2;
            const int MAX_Y = 1;

            var xRange = (x >= MIN_X && x <= MAX_X);
            var yRange = (y >= MIN_Y && y <= MAX_Y);

            if (xRange && yRange && shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}

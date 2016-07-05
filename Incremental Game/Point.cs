namespace Incremental_Game
{
    internal class Point
    {
        public Point()
        {
            StartingPoints();
        }

        public int StartingPoints()
        {
            return 0;
        }

        public int? ChangePoints(int currentPoints, int changeValue, string caseValue)
        {
            switch (caseValue)
            {
                case "Increase":
                    return Increase(currentPoints, changeValue);
                case "Decrease":
                    return Decrease(currentPoints, changeValue);
            }
            return null;
        }

        public int Increase(int currentPoints, int changeValue)
        {
            var newScore = currentPoints + changeValue;
            return newScore;
        }

        public int Decrease(int currentPoints, int changeValue)
        {
            var newScore = currentPoints - changeValue;
            return newScore;
        }
    }
}

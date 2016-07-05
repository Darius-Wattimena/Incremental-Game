using System.Runtime.Remoting.Messaging;

namespace Incremental_Game
{
    internal class Point
    {
        public int StartingPoints()
        {
            return 100000;
        }

        public double ChangePoints(double currentPoints, double changeValue, string caseValue)
        {
            if (caseValue != null)
            {
                switch (caseValue)
                {
                    case "Increase":
                        return Increase(currentPoints, changeValue);
                    case "Decrease":
                        return Decrease(currentPoints, changeValue);
                }
            }
            return 0;
        }

        public double Increase(double currentPoints, double changeValue)
        {
            var newScore = currentPoints + changeValue;
            return newScore;
        }

        public double Decrease(double currentPoints, double changeValue)
        {
            var newScore = currentPoints - changeValue;
            return newScore;
        }
    }
}

using System.Windows.Forms;

namespace Incremental_Game
{
    internal class Player
    {
        private readonly Point _points = new Point();
        private readonly Upgrade _upgrade = new Upgrade();
        public int Level;
        public double Points;

        public Player()
        {
            Level = 1;
            Points = _points.StartingPoints();
        }

        public double GetPoints()
        {
            return Points;
        }

        public string GetUpgradeCost(string naam)
        {
            return _upgrade.GetUpgradePrice(naam, Level).ToString();
        }

        public double Click(string change)
        {
            Points = _points.ChangePoints(Points, ChangeValue(), change);
            return Points;
        }

        public double ChangeValue()
        {
            var changeValue = Level * 0.5;
            return changeValue;
        }

        public void GetUpgrade(string upgradeName)
        {
            switch (upgradeName)
            {
                case "UpgradeClick":
                {
                    var price = _upgrade.GetUpgradePrice("Click", Level);
                    if (Points >= price)
                    {
                        Points = _points.ChangePoints(Points, price, "Decrease");
                        Level = ChangeLevel(Level);
                    }
                    return;
                }
            }
        }

        public int ChangeLevel(int currentLevel)
        {
            return currentLevel + 1;
        }
    }
}

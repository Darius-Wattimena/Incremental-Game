using System.Collections.Generic;

namespace Incremental_Game
{
    internal class Player
    {
        private readonly Point _points = new Point();
        private readonly Upgrade _upgrade = new Upgrade();
        private Upgrade _selectedUpgrade = new Upgrade();
        public double Points;
        public List<Upgrade> Upgrade = new List<Upgrade>();

        public Player()
        {
            Upgrade.Add(_upgrade.Upgrades("Click", 1));
            Upgrade.Add(_upgrade.Upgrades("Shervin", 0));
            Upgrade.Add(_upgrade.Upgrades("Ruben", 0));
            Upgrade.Add(_upgrade.Upgrades("Frank", 0));
            Points = _points.StartingPoints();
        }

        public double Click(string change, string name)
        {
            Points = _points.ChangePoints(Points, ChangeValue(name), change);
            return Points;
        }

        public double ReveivePoints()
        {
            foreach (var item in Upgrade)
            {
                if (item.Name != "Click")
                {
                    Points = _points.ChangePoints(Points, ChangeValue(item.Name), "Increase");
                }
            }
            return Points;
        }

        public void BuyUpgrade(string upgradeName)
        {
            foreach (var item in Upgrade)
            {
                if (item.Name != upgradeName) continue;
                _selectedUpgrade = item;
            }

            var upgradePrice = _upgrade.GetUpgradePrice(upgradeName, _selectedUpgrade.Level);
            if (Points >= upgradePrice)
            {
                Points = _points.ChangePoints(Points, upgradePrice, "Decrease");
                var level = ChangeLevel(_selectedUpgrade.Level);
                Upgrade.Remove(_selectedUpgrade);
                Upgrade.Add(_upgrade.Upgrades(upgradeName, level));
            }
        }

        public double ChangeValue(string name)
        {
            foreach (var item in Upgrade)
            {
                if (item.Name != name) continue;
                _selectedUpgrade = item;
            }
            if (_selectedUpgrade.Level == 0)
                return 0;
            var changeValue = _selectedUpgrade.Profit;
            return changeValue;
        }

        public int ChangeLevel(int currentLevel)
        {
            return currentLevel + 1;
        }

        public double GetPoints()
        {
            return Points;
        }

        public int GetUpgradeLevel(string upgradeName)
        {
            foreach (var item in Upgrade)
            {
                if (item.Name != upgradeName) continue;
                _selectedUpgrade = item;
            }
            return _selectedUpgrade.Level;
        }

        public Upgrade GetUpgradeInfo(string upgradeName, int currentLevel)
        {
            return _upgrade.Upgrades(upgradeName, currentLevel);
        }
    }
}

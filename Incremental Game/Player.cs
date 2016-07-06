using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Incremental_Game
{
    internal class Player
    {
        private readonly Point _points = new Point();
        private readonly Upgrade _upgrade = new Upgrade();
        public int ClickLevel;
        public int ShervinLevel;
        public int RubenLevel;
        public int FrankLevel;
        public double Points;
        public List<Upgrade> Upgrade = new List<Upgrade>();

        public Player()
        {
            ClickLevel = 1;
            ShervinLevel = 0;
            RubenLevel = 0;
            FrankLevel = 0;
            Upgrade.Add(_upgrade.Upgrades("Click", ClickLevel));
            Upgrade.Add(_upgrade.Upgrades("Shervin", ShervinLevel));
            Upgrade.Add(_upgrade.Upgrades("Ruben", RubenLevel));
            Upgrade.Add(_upgrade.Upgrades("Frank", FrankLevel));
            Points = _points.StartingPoints();
        }

        public double GetPoints()
        {
            return Points;
        }

        public string GetUpgradeCost(string naam)
        {
            return _upgrade.GetUpgradePrice(naam, ClickLevel).ToString();
        }

        public double Click(string change)
        {
            Points = _points.ChangePoints(Points, ChangeValue(), change);
            return Points;
        }

        public double ChangeValue()
        {
            var changeValue = ClickLevel * 0.5;
            return changeValue;
        }

        public int ChangeLevel(int currentLevel)
        {
            return currentLevel + 1;
        }

        public void GetUpgrade(string upgradeName)
        {
            switch (upgradeName)
            {
                case "UpgradeClick":
                    {
                        var price = _upgrade.GetUpgradePrice("Click", ClickLevel);
                        if (Points >= price)
                        {
                            Points = _points.ChangePoints(Points, price, "Decrease");
                            ClickLevel = ChangeLevel(ClickLevel);
                        }
                        return;
                    }
                case "UpgradeShervin":
                    {
                        var price = _upgrade.GetUpgradePrice("Shervin", ShervinLevel);
                        if (Points >= price)
                        {
                            Points = _points.ChangePoints(Points, price, "Decrease");
                            ShervinLevel = ChangeLevel(ShervinLevel);
                        }
                        return;
                    }
                case "UpgradeRuben":
                    {
                        var price = _upgrade.GetUpgradePrice("Ruben", RubenLevel);
                        if (Points >= price)
                        {
                            Points = _points.ChangePoints(Points, price, "Decrease");
                            RubenLevel = ChangeLevel(RubenLevel);
                        }
                        return;
                    }
                case "UpgradeFrank":
                    {
                        var price = _upgrade.GetUpgradePrice("Frank", FrankLevel);
                        if (Points >= price)
                        {
                            Points = _points.ChangePoints(Points, price, "Decrease");
                            FrankLevel = ChangeLevel(FrankLevel);
                        }
                        return;
                    }
            }
        }

        public Upgrade GetUpgradeInfo(string upgradeName, int currentLevel)
        {
            return _upgrade.Upgrades(upgradeName, currentLevel);
        }
    }
}

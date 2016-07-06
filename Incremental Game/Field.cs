using System.Globalization;

namespace Incremental_Game
{
    internal class Field
    {
        private readonly Player _player = new Player();
        public double ViewPoints;

        public Field()
        {
            ViewPoints = _player.GetPoints();
        }

        public string GetCurrentLevel(string upgradeName)
        {
            switch (upgradeName)
            {
                case "Click":
                    return _player.ClickLevel.ToString();
                case "Shervin":
                    return _player.ShervinLevel.ToString();
                case "Ruben":
                    return _player.RubenLevel.ToString();
                case "Frank":
                    return _player.FrankLevel.ToString();
            }
            return null;
        }
        public double GetCurrentPoints()
        {
            return _player.GetPoints();
        }

        public string GetUpgradeCost(string naam)
        {
            return _player.GetUpgradeCost(naam);
        }

        public void ClickReceive(string intention)
        {
            switch (intention)
            {
                case "ScoreClick":
                    ViewPoints = _player.Click("Increase");
                    return;
                case "UpgradeClick":
                    _player.GetUpgrade("Click");
                    return;
                case "UpgradeShervin":
                    _player.GetUpgrade("Shervin");
                    return;
                case "UpgradeRuben":
                    _player.GetUpgrade("Ruben");
                    return;
                case "UpgradeFrank":
                    _player.GetUpgrade("Frank");
                    return;

            }
            ViewPoints = _player.Click("Increase");
        }

        public string GetUpgradeData(string upgradeName, string returnName)
        {
            var upgrades = _player.Upgrade;
            foreach (var upgrade in upgrades)
            {
                if (upgrade.Name != upgradeName) continue;
                switch (returnName)
                {
                    case "Name":
                        return upgrade.Name;
                    case "Description":
                        return upgrade.Description;
                    case "Level":
                        return upgrade.Level.ToString();
                    case "LevelPlusOne":
                        return upgrade.Level+1.ToString();
                    case "Price":
                        return upgrade.Price.ToString(CultureInfo.CurrentCulture);
                    case "Profit":
                        return upgrade.Profit.ToString(CultureInfo.CurrentCulture);
                }
            }
            return null;
        }
    }
}

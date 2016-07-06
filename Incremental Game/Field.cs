using System.Globalization;

namespace Incremental_Game
{
    internal class Field
    {
        private readonly Player _player = new Player();
        public double ViewPoints;

        public void ClickReceive(string intention, string upgradeName)
        {
            switch (intention)
            {
                case "AddPoints":
                    ViewPoints = _player.Click("Increase", "Click");
                    return;
                case "BuyUpgrade":
                    _player.BuyUpgrade(upgradeName);
                    return;
                default:
                    return;
            }
        }

        public void TimerReceive()
        {
            _player.ReveivePoints();
        }

        public string GetCurrentLevel(string upgradeName)
        {
            return _player.GetUpgradeLevel(upgradeName).ToString();
        }

        public string GetCurrentPoints()
        {
            return _player.GetPoints().ToString(CultureInfo.CurrentCulture);
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
                    case "NewLevel":
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

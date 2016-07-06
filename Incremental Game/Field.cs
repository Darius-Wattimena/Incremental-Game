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

        public int GetCurrentLevel()
        {
            return _player.ClickLevel;
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
                    _player.GetUpgrade("UpgradeShervin");
                    return;

            }
            ViewPoints = _player.Click("Increase");
        }

        public string GetUpgradeData(string upgradeName, string returnName)
        {
            var upgrades = _player.Upgrade;
            foreach (var upgrade in upgrades)
            {
                if (upgrade.Name == upgradeName && returnName == "Name")
                    return upgrade.Name;
                if (upgrade.Name == upgradeName && returnName == "Description")
                    return upgrade.Description;
                if (upgrade.Name == upgradeName && returnName == "Level")
                    return upgrade.Level.ToString();
                if (upgrade.Name == upgradeName && returnName == "Price")
                    return upgrade.Price.ToString();
            }
            return null;
        }
    }
}

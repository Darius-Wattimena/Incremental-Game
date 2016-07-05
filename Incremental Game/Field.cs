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
            return _player.Level;
        }
        public string GetCurrentPoints()
        {
            return _player.GetPoints().ToString();
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
                    _player.GetUpgrade("UpgradeClick");
                    return;

            }
            ViewPoints = _player.Click("Increase");
        }
    }
}

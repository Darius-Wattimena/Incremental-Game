namespace Incremental_Game
{
    class Upgrade
    {
        public double GetUpgradePrice(string name, int level)
        {
            switch (name)
            {
                case "Click":
                    return 25 * level;
            }
            return 0;
        }
    }
}

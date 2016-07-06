using System.Collections.Generic;

namespace Incremental_Game
{

    internal class Upgrade : IUpgrade
    {
        public double GetUpgradePrice(string name, int level)
        {
            switch (name)
            {
                case "Click":
                    return 25 * level;
                case "Shervin":
                    return 100 * (level + 1);
                case "Ruben":
                    return 200 * (level + 1);
                case "Frank":
                    return 500 * (level + 1);
            }
            return 0;
        }

        public double GetProfit(string name, int level)
        {
            switch (name)
            {
                case "Click":
                    return 0.5 * level;
                case "Shervin":
                    return 2.5 * level;
                case "Ruben":
                    return 5.0 * level;
                case "Frank":
                    return 7.5 * level;
            }
            return 0;
        }

        public Upgrade Upgrades(string name, int level)
        {
            switch (name)
            {
                case "Click":
                    {
                        return new Upgrade
                        {
                            Name = "Click",
                            Description = "Upgrade your clicking power.",
                            Price = GetUpgradePrice(name, level),
                            Profit = GetProfit(name, level),
                            Level = level
                        };
                    }
                case "Shervin":
                    {
                        return new Upgrade
                        {
                            Name = "Shervin",
                            Description = "Get some good profit from this fake black guy.",
                            Price = GetUpgradePrice(name, level),
                            Profit = GetProfit(name, level),
                            Level = level
                        };
                    }

                case "Frank":
                    {
                        return new Upgrade
                        {
                            Name = "Frank",
                            Description = "Every waifus will give you money since Frank is a young god.",
                            Price = GetUpgradePrice(name, level),
                            Profit = GetProfit(name, level),
                            Level = level
                        };
                    }
                case "Ruben":
                    {
                        return new Upgrade
                        {
                            Name = "Ruben",
                            Description = "This guy wil invent your money in csgo stickers for some easy profit.",
                            Price = GetUpgradePrice(name, level),
                            Profit = GetProfit(name, level),
                            Level = level
                        };
                    }
            }
            return null;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Profit { get; set; }
        public int Level { get; set; }
    }
}

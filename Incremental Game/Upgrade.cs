using System;

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
                    return 500 * (level + 1);
                case "Ruben":
                    return 2500 * (level + 1);
                case "Frank":
                    return 20000 * (level + 1);
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
                    return RandomNumber(2) * level;
                case "Ruben":
                    return RandomNumber(10) * level;
                case "Frank":
                    return RandomNumber(50) * level;
            }
            return 0;
        }

        public double RandomNumber(int median)
        {
            var rnd = new Random();
            var value = rnd.Next(median - 5, median + 5);
            return value < 1 ? 1 : value;
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

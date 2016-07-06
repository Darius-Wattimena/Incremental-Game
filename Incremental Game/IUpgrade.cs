namespace Incremental_Game
{
    internal interface IUpgrade
    {
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        double Profit { get; set; }
        int Level { get; set; }
    }
}

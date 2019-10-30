namespace GameLibrary
{
    public interface IRoom
    {
        string ID { get; set; }
        string Description { get; set; }
        int East { get; set; }
        int North { get; set; }
        int South { get; set; }
        int West { get; set; }
    }
}
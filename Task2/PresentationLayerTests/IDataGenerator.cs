namespace PresentationLayerTests
{
    public interface IDataGenerator
    {
        string Description { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Title { get; set; }
    }
}
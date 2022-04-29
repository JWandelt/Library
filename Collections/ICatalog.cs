namespace DataLayer
{
    public interface ICatalog
    {
        int ItemID { get; set; }
        string ItemName { get; set; }
        string ItemShortDescription { get; set; }
    }
}
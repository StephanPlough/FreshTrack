namespace FreshTrack.Models
{
    public class Item
    {
        public int ItemId {get; set; }

        public int Quantity { get; set; }

        public string Location {get; set; }
        public string? ItemName { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}

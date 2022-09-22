namespace Domain.Entities
{
    public class CalendarEntity : BaseEntity
    {
        public int ListingId { get; private set; }
        public DateTime Date { get; private set; }
        public bool Available { get; private set; }
        public decimal Price { get; private set; }

        public CalendarEntity() { }

        public CalendarEntity(int id, int listingId, DateTime date, bool available, decimal price)
        {
            Id = id;
            ListingId = listingId;
            Date = date;
            Available = available;
            Price = price;
        }
    }
}
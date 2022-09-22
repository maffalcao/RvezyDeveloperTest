namespace Domain.Entities
{
    public class Listing : BaseEntity
    {
        public int Id { get; private set; }
        public string ListingUrl { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string PropertyType { get; private set; }

        public Listing(int id, string listingUrl, string name, string description, string propertyType)
        {
            Id = id;
            ListingUrl = listingUrl;
            Name = name;
            Description = description;
            PropertyType = propertyType;
        }

    }
}
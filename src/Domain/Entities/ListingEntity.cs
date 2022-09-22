namespace Domain.Entities
{
    public class ListingEntity : BaseEntity
    {
        public string ListingUrl { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string PropertyType { get; private set; }

        public ListingEntity(int id, string listingUrl, string name, string description, string propertyType)
        {
            Id = id;
            ListingUrl = listingUrl;
            Name = name;
            Description = description;
            PropertyType = propertyType;
        }

    }
}
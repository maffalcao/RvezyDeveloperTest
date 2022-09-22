namespace Domain.Entities
{
    public class ReviewEntity : BaseEntity
    {
        public int ListingId { get; private set; }
        public DateTime Date { get; private set; }
        public int ReviewerId { get; private set; }
        public string? ReviewerName { get; private set; }
        public string? Comments { get; private set; }

        public ReviewEntity()
        {
        }

        public ReviewEntity(int id, int listingId, DateTime date, int reviewerId, string reviewerName, string comments)
        {
            Id = id;
            ListingId = listingId;
            Date = date;
            ReviewerId = reviewerId;
            ReviewerName = reviewerName;
            Comments = comments;
        }


    }
}
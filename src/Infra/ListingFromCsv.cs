using Domain.Entities;
using Domain.Interfaces;

namespace Infra
{
    public class ListingFromCsv : FromCsvBase, IListingFromCsv
    {
        /* TODO: move this contants to settings files */

        private int PAGE_SIZE = 10;
        private IList<Listing> Listings { get; }

        public ListingFromCsv()
        {
            FILE_PATH = "../Files/listings.csv";
            Listings = new List<Listing>();
            GetFileData();
        }
        public Listing GetById(int id) =>
            Listings.SingleOrDefault(_ => _.Id == id);

        public IList<Listing> GetPaged(string? propertyType = null, int pageNumber = 1) =>
            Listings
                .Where(_ => propertyType == null || _.PropertyType == propertyType)
                .Skip((pageNumber - 1) * PAGE_SIZE)
                .ToList();


        protected override void ProccessLineContent(string lineContent)
        {
            const int listingTokenSize = 5;
            var token = lineContent.Split(new string[] { ",\"", "\"," }, StringSplitOptions.RemoveEmptyEntries);

            if (int.TryParse(token[0], out int value))
            {
                if (token.Count() != listingTokenSize)
                    throw new Exception("Csv file for listing not in a valid format");
                Listings.Add(new Listing(
                    int.Parse(token[0]),
                    token[1],
                    token[2],
                    token[3],
                    token[4]
                ));
            }
        }
    }
}

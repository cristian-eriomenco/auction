using Auctionata.Domain.Interfaces;

namespace Auctionata.Domain.Contracts.Messages
{
    public class BidderAddedToAuction : IAuctionEvent
    {
        public AuctionId Id { get; private set; }
        public string BidderName { get; private set; }

        public BidderAddedToAuction() { }

        public BidderAddedToAuction(AuctionId id, string bidderName)
        {
            Id = id;
            BidderName = bidderName;
        }

        public override string ToString()
        {
            return string.Format(@"New bidder joins  auction '{0}'", BidderName);
        }
    }
}

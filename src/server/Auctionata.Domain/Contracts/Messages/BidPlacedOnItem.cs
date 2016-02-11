using Auctionata.Domain.Interfaces;

namespace Auctionata.Domain.Contracts.Messages
{
    public class BidPlacedOnItem : IAuctionEvent
    {
        public AuctionId Id { get; private set; }
        public string BidderName { get; private set; }

        public BidPlacedOnItem() { }

        public BidPlacedOnItem(AuctionId id, string bidderName)
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

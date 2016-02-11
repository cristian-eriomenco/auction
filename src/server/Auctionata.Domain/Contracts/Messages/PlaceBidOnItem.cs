using Auctionata.Domain.Interfaces;

namespace Auctionata.Domain.Contracts.Messages
{
    public class PlaceBidOnItem : IAuctionCommand
    {
        public AuctionId Id { get; private set; }
        public string BidderName { get; private set; }

        public PlaceBidOnItem() { }

        public PlaceBidOnItem(AuctionId id, string bidderName)
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

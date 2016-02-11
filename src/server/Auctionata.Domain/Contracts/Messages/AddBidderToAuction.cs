using Auctionata.Domain.Interfaces;

namespace Auctionata.Domain.Contracts.Messages
{
    public class AddBidderToAuction : IAuctionCommand
    {
        public AuctionId Id { get; private set; }
        public string BidderName { get; private set; }

        public AddBidderToAuction() { }

        public AddBidderToAuction(AuctionId id, string bidderName)
        {
            Id = id;
            BidderName = bidderName;
        }

        public override string ToString()
        {
            return string.Format(@"Add bidder to auction '{0}'", BidderName);
        }
    }
}

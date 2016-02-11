using Auctionata.Domain.Interfaces;

namespace Auctionata.Domain.Contracts.Messages
{
    public class AuctionOpened : IAuctionEvent
    {
        public AuctionId Id { get; private set; }
        public string AuctionName { get; private set; }

        public AuctionOpened() { }

        public AuctionOpened(AuctionId id, string auctionName)
        {
            Id = id;
            AuctionName = auctionName;
        }

        public override string ToString()
        {
            return string.Format(@"Opened auction(ID='{0}')", Id.ToString());
        }
    }
}

using Auctionata.Domain.Interfaces;

namespace Auctionata.Domain.Contracts.Messages
{
    public class OpenAuction : IAuctionCommand
    {
        public AuctionId Id { get; private set; }
        public string AuctionName { get; private set; }

        public OpenAuction() { }

        public OpenAuction(AuctionId id, string auctionName)
        {
            Id = id;
            AuctionName = auctionName;
        }

        public override string ToString()
        {
            return string.Format(@"Open auction(ID='{0}')", Id);
        }
    }
}

using Auctionata.Domain.Contracts.Messages;

namespace Auctionata.Domain.Contracts
{
    public interface IAuctionApplicationService
    {
        void When(OpenAuction e);
        void When(AddBidderToAuction e);
        void When(PlaceBidOnItem e);
    }
}

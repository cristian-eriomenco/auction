using Auctionata.Domain.Contracts;

namespace Auctionata.Domain.Interfaces
{
    public interface IAuctionEvent : IEvent
    {
        AuctionId Id { get; }
    }
}

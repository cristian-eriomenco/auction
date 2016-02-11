using Auctionata.Domain.Contracts;

namespace Auctionata.Domain.Interfaces
{
    public interface IAuctionCommand : ICommand
    {
        AuctionId Id { get; }
    }
}

using System.Collections.Generic;
using Auctionata.Domain.Contracts;
using Auctionata.Domain.Contracts.Messages;
using Auctionata.Domain.Interfaces;

namespace Auctionata.Domain.ApplicationServices.Auction
{
    public class AuctionAggregate
    {
        public List<IEvent> EventsThatHappened = new List<IEvent>();

        readonly AuctionState _aggregateState;
        public AuctionAggregate(AuctionState aggregateState)
        {
            _aggregateState = aggregateState;
        }

        public void OpenAuction(AuctionId id, string auctionName)
        {
            if (_aggregateState.Id != null)
                throw DomainError.Named("auction-already-created", "Auction was already created");

            RecordAndRealizeThat(new AuctionOpened(id, auctionName));
        }

        public void BidPlacedOnItem(AuctionId id, string bidderName)
        {
            ThrowExceptionIfAuctionIsNotOpen();

            RecordAndRealizeThat(new BidPlacedOnItem(_aggregateState.Id, bidderName));
        }

        public void AddBidderToAuction(AuctionId id, string bidderName)
        {
            ThrowExceptionIfAuctionIsNotOpen();

            RecordAndRealizeThat(new BidderAddedToAuction(_aggregateState.Id, bidderName));
        }

        void RecordAndRealizeThat(IEvent e)
        {
            EventsThatHappened.Add(e);

            _aggregateState.MakeAggregateRealize(e);
        }

        void ThrowExceptionIfAuctionIsNotOpen()
        {
            if (_aggregateState.Id == null)
                throw DomainError.Named("auction-is-not-open", "Auction is not open");
        }
    }
}

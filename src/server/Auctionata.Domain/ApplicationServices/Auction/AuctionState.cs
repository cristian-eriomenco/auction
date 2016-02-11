using System;
using System.Collections.Generic;
using Auctionata.Domain.Contracts;
using Auctionata.Domain.Contracts.Messages;
using Auctionata.Domain.Interfaces;

namespace Auctionata.Domain.ApplicationServices.Auction
{
    public class AuctionState : IAuctionState
    {
        public AuctionId Id { get; private set; }

        public bool IsOpened { get; private set; }

        public readonly List<string> ListOfBidderNames = new List<string>();

        public AuctionState(IEnumerable<IEvent> allEventsRelatedToThisAggregateId)
        {
            foreach (var eventThatHappened in allEventsRelatedToThisAggregateId)
            {
                MakeAggregateRealize(eventThatHappened);
            }
        }

        public void When(AuctionOpened e)
        {
            Id = e.Id;
            IsOpened = true;
        }

        public void When(BidderAddedToAuction e)
        {
            ListOfBidderNames.Add(e.BidderName);
        }

        public void When(BidPlacedOnItem e)
        {
            throw new NotImplementedException();
        }

        public void MakeAggregateRealize(IEvent e)
        {
            ((dynamic)this).When((dynamic)e);
        }
    }
}

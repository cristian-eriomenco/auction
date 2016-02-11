using System;
using Auctionata.Domain.Contracts;
using Auctionata.Domain.Contracts.Messages;
using Auctionata.Domain.Interfaces;

namespace Auctionata.Domain.ApplicationServices.Auction
{
    public class AuctionApplicationService : IAuctionApplicationService, IApplicationService
    {
        private readonly IEventStore _eventStore;

        public AuctionApplicationService(IEventStore eventStore)
        {
            _eventStore = eventStore;
        }

        private void Update(IAuctionCommand forAggregateIdentifiedBy, Action<AuctionAggregate> executeCommandUsingThis)
        {
            var key = forAggregateIdentifiedBy.Id.ToString();
            var eventStream = _eventStore.LoadEventStream(key);

            var aggregateState = new AuctionState(eventStream.Events);
            var aggregate = new AuctionAggregate(aggregateState);

            executeCommandUsingThis(aggregate);

            _eventStore.AppendEventsToStream(key, eventStream.StreamVersion, aggregate.EventsThatHappened);
        }

        public void When(OpenAuction cmd)
        {
            Update(cmd, ar => ar.OpenAuction(cmd.Id, cmd.AuctionName));
        }

        public void When(AddBidderToAuction cmd)
        {
            Update(cmd, ar => ar.AddBidderToAuction(cmd.Id, cmd.BidderName));
        }

        public void When(PlaceBidOnItem cmd)
        {
            Update(cmd, ar => ar.BidPlacedOnItem(cmd.Id, cmd.BidderName));
        }

        public void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }
    }
}

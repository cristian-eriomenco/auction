using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Auctionata.Domain.Interfaces;

namespace Auctionata.Tests
{
    public class InMemoryStore : IEventStore
    {
        readonly ConcurrentDictionary<string, IList<IEvent>> _eventStore = new ConcurrentDictionary<string, IList<IEvent>>();
        readonly SynchronousEventHandler _eventHandler;

        public InMemoryStore(SynchronousEventHandler eventHandler)
        {
            _eventHandler = eventHandler;
        }

        public EventStream LoadEventStream(string id)
        {
            var eventStream = _eventStore.GetOrAdd(id, new IEvent[0]).ToList();

            return new EventStream()
            {
                Events = eventStream,
                StreamVersion = eventStream.Count
            };
        }

        public void AppendEventsToStream(string id, long expectedVersion, ICollection<IEvent> events)
        {
            _eventStore.AddOrUpdate(id, events.ToList(), (s, list) => list.Concat(events).ToList());

            foreach (var @event in events)
            {
                _eventHandler.Handle(@event);
            }
        }
    }
}

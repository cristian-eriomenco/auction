using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctionata.Domain.Interfaces
{
    public interface IEventStore
    {
        EventStream LoadEventStream(string id);
        void AppendEventsToStream(string id, long expectedVersion, ICollection<IEvent> events);
    }
}

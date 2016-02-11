using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctionata.Domain.Interfaces
{
    public class EventStream
    {
        public long StreamVersion;
        public List<IEvent> Events = new List<IEvent>();
    }
}

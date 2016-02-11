using System.Collections.Generic;
using Auctionata.Domain.Interfaces;
using Microsoft.CSharp.RuntimeBinder;

namespace Auctionata.Tests
{
    public sealed class SynchronousEventHandler 
    {
        readonly IList<object> _eventHandlers = new List<object>();
        public void Handle(IEvent @event)
        {
            foreach (var eventHandler in _eventHandlers)
            {
                try
                {
                    ((dynamic)eventHandler).When((dynamic)@event);
                }
                catch (RuntimeBinderException e)
                {
                    // binding failure. Ignore
                }
            }
        }
        public void RegisterHandler(object projection)
        {
            _eventHandlers.Add(projection);
        }
    }
}

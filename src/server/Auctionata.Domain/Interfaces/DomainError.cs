using System;
using System.Runtime.Serialization;

namespace Auctionata.Domain.Interfaces
{
    public class DomainError : Exception
    {
        public DomainError(string message) : base(message) { }

        public static DomainError Named(string name, string format, params object[] args)
        {
            return new DomainError(string.Format(format, args))
            {
                Name = name
            };
        }

        public string Name { get; private set; }

        public DomainError(string message, Exception inner) : base(message, inner) { }

        protected DomainError(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context) { }
    }
}
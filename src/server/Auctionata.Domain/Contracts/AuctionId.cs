using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctionata.Domain.Contracts
{
    public class AuctionId
    {
        public AuctionId(long id)
        {
            Id = id;
        }

        public long Id { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}", GetType().Name.Replace("Id", ""), Id);
        }
    }
}

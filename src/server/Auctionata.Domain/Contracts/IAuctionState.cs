using Auctionata.Domain.Contracts.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctionata.Domain.ApplicationServices.Auction
{
    public interface IAuctionState
    {
        void When(AuctionOpened e);
        void When(BidderAddedToAuction e);
        void When(BidPlacedOnItem e);
    }
}

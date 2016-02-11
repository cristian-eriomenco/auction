using System;
using TechTalk.SpecFlow;

namespace Auctionata.Tests
{
    [Binding]
    public class AuctionSteps
    {
        [Given(@"I am in the auction room")]
        public void GivenIAmInTheAuctionRoom()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the current item picture, description and name")]
        public void ThenISeeTheCurrentItemPictureDescriptionAndName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the current highest bid with a button to place a new bid")]
        public void ThenISeeTheCurrentHighestBidWithAButtonToPlaceANewBid()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I place a bid o an item")]
        public void ThenIPlaceABidOAnItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am the only bidder")]
        public void ThenIAmTheOnlyBidder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am the highest bidder")]
        public void ThenIAmTheHighestBidder()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

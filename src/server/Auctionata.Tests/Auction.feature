Feature: Auction
	As a potential buyer in an online auction
	I want to be able to bid on an item
	So that I can participate in the auction

Scenario: Displaing information about the current item
	Given I am in the auction room
	Then I see the current item picture, description and name
    And I see the current highest bid with a button to place a new bid

Scenario: single user bidding on an item
	Given I am in the auction room
	Then I place a bid o an item
    And I am the only bidder
    Then I am the highest bidder
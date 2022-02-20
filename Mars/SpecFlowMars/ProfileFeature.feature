Feature: ProfileFeature

As a seller
 I want the feature to add my Profile Details
So that
 The people seeking for some skills can look into my details
 
 @tag1

Scenario:6  [Seller is able to add description]
	Given   [I am logged in successfully]
	When    [I add description]
	Then    [Description should be saved]

Scenario: 7 [Seller is able to change their name]
	Given   [I am logged in successfully]
	When    [I change firstname and lastname]
	Then    [Name details should be saved]

Scenario: 8 [Seller is able to update the profile details]
	Given   [I am logged in successfully]
	When    [I update profile details]
	Then    [Profile details should be updated]

Scenario: 9 [Seller is able to delete the profile details]
	Given   [I am logged in successfully]
	When    [I delete profile details]
	Then    [Profile details should be deleted] 


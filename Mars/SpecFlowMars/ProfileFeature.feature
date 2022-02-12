Feature: ProfileFeature

As a seller
 I want the feature to add my Profile Details
So that
 The people seeking for some skills can look into my details

@tag1
Scenario:1  [Seller is able to add language]
	Given   [I am logged in successfully]
	When    [I add language details]
	Then    [Language Details should be saved]

Scenario:2 [Seller is able to add skill]
	Given  [I am logged in successfully]
	When   [I add Skill details]
	Then   [Skill Details should be saved]

Scenario:3 [Seller is able to add education]
	Given  [I am logged in successfully]
	When   [I add education details]
	Then   [Education Details should be saved]

Scenario:4 [Seller is able to add certifications]
	Given  [I am logged in successfully]
	When   [I add certification details]
	Then   [Certification Details should be saved]

Scenario: 5 [Seller is able to add Availability,Hours and EarnTarget details]
    Given   [I am logged in successfully]
	When    [I add Availability,Hours and EarnTarget details]
	Then    [All details should be saved]

Scenario: 6 [Seller is able to add description]
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
	



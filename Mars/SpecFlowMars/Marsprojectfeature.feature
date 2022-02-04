Feature: Marsprojectfeature
As a seller
 I want the feature to add my Profile Details
So that
 The people seeking for some skills can look into my details

@tag1
Scenario: 1 Seller is able to add the profile details
	Given [Logged into the home page successfully ]
	And   [I navigate to Profile tab]
	When  [I will add new profile details]
	Then  [Seller is able to see the seller's details on the Profile page]

#Scenario: 2 Seller is able to edit existing profile details with valid data
#    Given [Logged into the home page successfully]
#	And   [I navigate to Profile tab]
#	When  [I upadte the profile details]
#	Then  [The profile should have an updated detaials]
#
#Scenario:3 Seller is able to delete the existing record
#    Given [Logged into the home page successfully]
#	And   [I navigate to Profile tab]
#	When  [I delete the profile details]
#	Then  [The profile should be deleted successfully]
#


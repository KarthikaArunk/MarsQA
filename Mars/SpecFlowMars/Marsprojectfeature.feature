Feature: Marsprojectfeature
As a seller
 I want the feature to add my Profile Details
So that
 The people seeking for some skills can look into my details

@tag1
Scenario: 1 Seller is able to add new skill details
    Given [I logged into the home page successfully ]
	When  [I click on skill tab]
	Then  [Skill details should be added successfully]

Scenario: 2 Seller is able to add new language details
	Given [I logged into the home page successfully ]
	When  [I click on language tab]
	Then  [Language details should be added successfully]

Scenario: 3 Seller is able to add education details
    Given [I logged into the home page successfully ]
	When  [I click on Education tab]
	Then  [Education details should be added successfully]

Scenario: 4 Seller is able to add certification details
    Given [I logged into the home page successfully ]
	When  [I click on Certification tab]
	Then  [Certification details should be added successfully]

Scenario: 5 Seller is able to view profile details
   Given  [I logged into the home page successfully ]
   When   [I click on Language,Skill,Education and Certification Tabs]
   Then   [All profile details should be able to view]

#Scenario: 5 Seller is able to view language details
#   Given  [I logged into the home page successfully ]
#   When   [I click on langugae tab]
#   Then   [Seller should be able to view the language details]

#Scenario: 6 Seller is able to view skill details
#  Given   [I logged into the home page successfully ]
#  When    [I click on skill tab]
#  Then    [Seller should be able to view the skill details]
#
# Scenario: 7 Seller is able to view education details
#  Given    [I logged into the home page successfully ]
#  When     [I click on Education tab]
#  Then     [Seller should be able to view education details]
#
# Scenario: 8 Seller is able to view certification details
#   Given    [I logged into the home page successfully ]
#   When     [I click on Certification tab]
#   Then     [Seller should be able to view certification details]

#Scenario: 9 Seller is able to add Availability,Hours,Earn Target
#   Given   [I logged into the home page successfully ]
#   When    [I add Availability, Hours and Earn Target]
#   Then    [Availability,Hours and Earn Target should be added successfully]





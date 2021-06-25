Feature: TaxamoSpecFlowFeature
	As a customer 
	I want to be able to signup

@mytag
Scenario Outline: Customer can signup
	Given i navigate to Taxamo website
	And i am on the signup page
	And input "<Firstname>" "<Lastname>" "<Emailaddress>" "<Company>"
	And click the checkbox
	When i click signup cta button
	Then i am signed up

	Scenarios: 
	| Firstname | Lastname | Emailaddress         | Company  |
	| test      | test     | testingdemo@test.com | testthis |
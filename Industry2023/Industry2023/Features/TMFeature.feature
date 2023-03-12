Feature: TMFeature

Aas a TurnUp portal admin 
I would like to create, edit time and material records 
so that I can manage employee's time and meterial successsfully.

@tag1
Scenario: Create time and material record with valid details
	Given I logged turnup portal successfully
	When Inavigate to Time and material page
	And Icreate a new time and meterial record 
	Then The record should be created successfully

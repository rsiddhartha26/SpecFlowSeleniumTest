Feature: SearchYoutube

A short summary of the feature

@tag1
Scenario: Check Youtube search feature
	Given Youtube is open in chrome
	When I type 'India' on search
	Then results shown

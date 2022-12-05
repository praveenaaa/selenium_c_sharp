Feature: Recharge

A short summary of the feature


Scenario: To Validate that user is able to recharge Mobile number with valid inputs to earn points.
	Given Open Browser  and Enter URL for the website 
  And Click on login 
    And Log in using Valid Inputs.
    And Click on Explore Menu
   When click on Recharge
    And recharge page is displayed
    And click on Mobile Recharge
    When User enters Mobile number "9028562551" and amount "100"
    And click on checkbox
    And click on place order
	Then User is able to recharge



 #   Scenario: To Validate that user is able to recharge mobile with invalid inputs to earn points.
#	Given Open Browser  and Enter URL for the website 
#   And Click on login 
#    And Log in using Valid Inputs.
#    And Click on Explore Menu
#   When click on Recharge
#    And recharge page is displayed
 #   And click on Mobile Recharge
       
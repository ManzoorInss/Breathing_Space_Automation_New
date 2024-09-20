Feature: EndToEndJourney

A short summary of the feature

@UI
Scenario: Happy Path End To End Journey
	Given I open the ODS BKT Homepage
	When I create a new account using the email 'Happy@Path.com'
	And I confirm my personal details
	And I confirm my employment details
	And I confirm I had no bank accounts and savings
	And I confirm I have no assets
	And I confirm the money I owe
	And I confirm I have no income and expenses
	And I confirm I have no legal proceedings
	And I confirm my debt history
	And I pay my fee
	And I submit my application
	Then the application is submitted
	When I log into ODS Adjudicator
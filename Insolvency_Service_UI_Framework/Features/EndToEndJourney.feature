Feature: EndToEndJourney

A short summary of the feature

@UI
Scenario:E2E-1 Happy Path End To End Journey
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

	@UI
Scenario:E2E-2 Happy Path End To End Journey With Alias Name
	Given I open the ODS BKT Homepage
	When I create a new account using the email 'Happy@Path.com'
	And I confirm my personal details including alias
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

				@UI
Scenario:E2E-3 Happy Path End To End Journey Including Anyone Who Lives With You And Financially Dependant
	Given I open the ODS BKT Homepage
	When I create a new account using the email 'Happy@Path.com'
	And I confirm my personal details including anyone who lives with you
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

		@UI
Scenario:E2E-4 Happy Path End To End Journey Including Dependants Who Dont Live With You
	Given I open the ODS BKT Homepage
	When I create a new account using the email 'Happy@Path.com'
	And I confirm my personal details including dependants who dont live with you
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

			@UI
Scenario:E2E-5 Happy Path End To End Journey With AliasName Including Anyone Who Lives With You
	Given I open the ODS BKT Homepage
	When I create a new account using the email 'Happy@Path.com'
	And I confirm my personal details with AliasName Including anyone who lives with you
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

				@UI
Scenario:E2E-6 Happy Path End To End Journey With AliasName, Anyone Who Lives With You, Dependants Who Dont Live With you
	Given I open the ODS BKT Homepage
	When I create a new account using the email 'Happy@Path.com'
	And I confirm my personal details with AliasName, Anyone Who Lives With You, Dependants Who Dont Live With you
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

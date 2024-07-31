Feature: PetStoreGuestUser

A short summary of the feature

@homepage @guest @webapplication
Scenario: Guest User Browsing products
	Given PetStore is opened
	When a guest user visits 
	Then shopping cart is empty

Scenario: Guest User Adding items to cart 
	Given PetStore is opened
	When a guest user adds fish 
	Then shopping cart should have fish

Scenario Template: Admin Creates Users
Given The admin has permission to create users
  When admin creates profile with <Language> <Fav> <List> <Banner>
  Then The created profiles should match as per input
  Examples: 
    | Language | Fav  | List | Banner |
	| en       | fish | on   | on     |
	| en       | fish | off  | on     |
	| en       | fish | on   | off    |
	| en       | fish | on   | on     |
	| en       | fish | off  | on     |
	| en       | fish | on   | off    |
  
Scenario: Data Table Demo
Given the following users exist:
  | name   | email              | twitter         |
  | Aslak  | aslak@cucumber.io  | @aslak_hellesoy |
  | Julien | julien@cucumber.io | @jbpros         |
  | Matt   | matt@cucumber.io   | @mattwynne      |
  
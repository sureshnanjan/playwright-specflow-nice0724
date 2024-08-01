Feature: Heroku App Features
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](HerokuApp.Features/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@homepage
Scenario: The Heading is implemented correct
	Given The Application is available
	When the heading is accessed
	Then is should be "Welcome to the-internet"

@homepage
Scenario: The Sub Heading is implemented correct
	Given The Application is available
	When the sub heading is accessed
	Then is should be "Available Examples"

Scenario: All examples are available on homepage.
	Given The Application is available
	When available examples are checked
	Then it should have 45 examples

Scenario: Navigating to examples works
	Given The Application is available
	When the example "AddRemove" is accessed
	And the heading is accessed
	Then is should be "Add/Remove Elements"

Scenario: Adding elements work
	Given The Application is available
	And the example "AddRemove" is accessed
	When 1 more element is added
	Then the added elements count is 1

Scenario: ABTest disabling works
	Given The Application is available
	And the example "ABTest" is accessed
	And ABTesting is disabled
	When the heading is accessed
	Then is should be "NO ABTest"

Scenario: Broken Images can be correctly detected
	Given The Application is available
	And the example "BrokenImages" is accessed
	When the IMage1 details is accessed
	Then it should point to images in the img folder

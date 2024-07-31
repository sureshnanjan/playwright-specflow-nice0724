Feature: BinarySearcher
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](AcceptanceTestsBinarySearcher/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Element Found
	Given the input is 1,2,3,4,5
	When I search for 2
	Then the result should be 1

Scenario: Element Found end of input
	Given the input is 1,2,3,4,5
	When I search for 5
	Then the result should be 4

Scenario: Element Found beginning of input
	Given the input is 1,2,3,4,5
	When I search for 1
	Then the result should be 0

Scenario: Element Not Found
	Given the input is 1,2,3,4,5
	When I search for 10
	Then the result should be not be 4

Scenario: Element Not Found lesser t
	Given the input is 1,2,3,4,5
	When I search for 10
	Then the result should be not be 4

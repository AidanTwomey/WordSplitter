Feature: CountInstances
	In order to avoid repeating myself
	As an author
	I want to be know the number of times each word appears in a sentence

@counting
Scenario: CountInstancesOfWords
	Given I have a sentence "This is a statement. and so is this"
	When I call CountInstances
	Then the result should be 
	| Word      | Count |
	| this      | 2     |
	| is        | 2     |
	| a         | 1     |
	| statement | 1     |
	| and       | 1     |
	| so        | 1     |

Feature: Paint
@mytag
Scenario: Compare two images
	Given Paint was opened
		And Image was uploaded
		And Image was cutted
	When The user closes paint
		And The user doesn't save the changes
	Then The original image is the same
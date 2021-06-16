Feature: FormFeatures
	basic blank validation 




Scenario: User fills out form
	Given User is on the form page
	
	When User leaves form blank
	And clicks Sign in button
	Then Alert will read "Email is blank"


	When User leaves password blank
	And clicks Sign in button
	Then Alert will read "password is blank"
	
	When User leaves address blank
	And clicks Sign in button
	Then Alert will read "address is blank"

	When User leaves city blank
	And clicks Sign in button
	Then Alert will read "city is blank"

	When User leaves zip blank
	And clicks Sign in button
	Then Alert will read "zip is blank"


Scenario: User fils out form correctly
	Given User is on the form page
	When User inputs all information
	And clicks Sign in button
	Then Alert will read "Submited Form" 

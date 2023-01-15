Feature: Authentication
	As a user
	I want to be able to authenticate to the app
	So I can work with restricted web app content

@mytag
Scenario: User can log in
	Given user opens sign in page
		And enters correct credentials
	When user submit login form
	Then user will be logged in

Scenario: User can sign up
	Given user opens sign in page
		And enters 'Vladimir' name and valid email address
		And user clicks on SignUp button
	When user fills in all required fields
		And submits the signup form
	Then user will get 'Account Created!' success message
		And user will be logged in

Scenario: User can delete their account
	Given user opens sign in page
		And enters 'Vladimir' name and valid email address
		And user clicks on SignUp button
		And user fills in all required fields
		And submits the signup form
		And user will get 'Account Created!' success message
	When user clicks on DeleteAccount butoon
	Then account will be deleted with message 'Account Deleted!'

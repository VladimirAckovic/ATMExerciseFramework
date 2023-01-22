Feature: CheckOut
	As a user
	I want to be able to add products to cart
	Proceed to chekout
	And enter Visa card data

@mytag
Scenario: User can pay with Visa card
	Given user opens sign in page
		And enters correct credentials
		And user submit login form
		And user opens products page
		And searches for 'Winter top' term
		And opens first search result
		And user click on Add to Cart button
		And proceeds to cart
	When user click on Proceed To Chekout button
		And enter message about order
		And user click on Place Order button
		And user enter valid Visa cart data
		And user click on Pay and Confirm Order button
	Then user will get 'Order Placed!' success message
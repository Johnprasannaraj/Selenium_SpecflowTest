Feature:Test the customerlist of Azurewebsite
	@mytag
Scenario: Test scenario for AzureWebsite
	Given User is at selenium test web page
	When I click on John Smith "Click to view details" button 
	Then the John Smith Details should be displayed under selenium test section
	When I click on Jeff Bridges "Click to view details" button 
	Then the Jeff Bridges Details should be displayed under selenium test section
	When I click on Steve Jones "Click to view details" button 
	Then the Steve Jones Details should be displayed under selenium test section

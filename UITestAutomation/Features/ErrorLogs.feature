﻿Feature: ErrorLogs

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@tag1
Scenario: Error Logs
	Given User clicks the Profile Icon on the Dashboard page
	And User selects the Error Logs Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Error Logs Page
		| UI Controls               |
		| Search and set date Range |
		| Created On                |
		| Error Message             |
		| URL                       |

	And User validates the following Fields on Search Popup on Error Logs Page
		| Fields     |
		| Start Date |
		| End Date   |
		| Close      |
		
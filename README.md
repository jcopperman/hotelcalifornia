# Project: hotelcalifornia
This repository is a story about an intrepid adventurer who seeks to uncover the secrets of a fictitious hotel

## PART 1: Manual test approach

### Summary
The test approach and documentation thereof follows the Behaviour Driven Development (BDD) design pattern which aims to provide clarity in adherence with the Product Owner and/or Stakeholder requirements which should be easily followed by a developer and software quality analyst in implementation and testing. The following test cases are intended to cover testing for basic CRUD (Create, Read, Update & Delete) functionality.

#### TEST CASE 001: The intrepid adventurer is able to find the hotel's homepage
1. Navigate to the Hotel Booking URL
2. Verify that the correct landing page is displayed

- **EXPECTED RESULT:**
- **ACTUAL RESULT:**

#### TEST CASE 002: The intrepid adventurer is able to view existing booking records
1. Given you have navigated to the Hotel Booking URL
2. When the correct landing page is displayed
3. Then you should see a list of existing bookings

- **EXPECTED RESULT:**
- **ACTUAL RESULT:**

#### TEST CASE 003: The intrepid adventurer is able to create a new booking record
1. Given you have navigated to the Hotel Booking URL
2. When the correct landing page is displayed
3. And you enter a new record with the correct fields
4. When you click "Save"
5. Then your new record is persisted to the list of records

- **EXPECTED RESULT:**
- **ACTUAL RESULT:**

#### TEST CASE 004: The intrepid adventurer is able to remove their booking record
1. Given you have navigated to the Hotel Booking URL
2. When the correct landing page is displayed

- **EXPECTED RESULT:**
- **ACTUAL RESULT:**

#### TEST CASE 005: The intrepid adventurer is able to edit an existing booking record
1. Given you have navigated to the Hotel Booking URL
2. When the correct landing page is displayed
3. And you enter a new record with the correct fields
4. When you click "Save"
5. Then your new record is persisted to the list of records

- **EXPECTED RESULT:**
- **ACTUAL RESULT:**

#### TEST CASE 006: The intrepid adventurer ascertains whether the hotel's site is secure
1. Given you have navigated to the Hotel Booking URL
2. When the correct landing page is displayed
3. Then verify that the website has a valid SSL certificate

- **EXPECTED RESULT:**
- **ACTUAL RESULT:**

##### Notes
A traditional test case would look like the following:

#### Considerations
As this web app is hosted for the purpose of assessments no load/performance testing was performed

## PART 2: Test Automation with .NET


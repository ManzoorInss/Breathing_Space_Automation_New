Feature: BreathingPaceEndToEndJourney

Background: Log in to Breathing Space application
  Given I log into the Breathing Space Application

@UI @UI-E2E
  Scenario Outline: Start of Standard BreathingSpace - Add previous name - Change debtor name and previous name and address
    When I navigate to the Breathing Space portal homepage
      And I select organisation from the following:
    | User          | Organisation    |
    | Money Advisor | <Organisation> |
    And I choose to create a Breathing Space
    |Organisation  | ActiveBSLink   | ReviewDebtLink   | ProposedDebtLink   | SoldDebtLink   | TransferClientLink   | TransferredClientsLink   |
    |<Organisation>  | <ActiveBSLink> | <ReviewDebtLink> | <ProposedDebtLink> | <SoldDebtLink> | <TransferClientLink> | <TransferredClientsLink> |

    And I enter the client details for name summary
        | ClientDetailsFields       | FirstName | MiddleName | LastName | BirthDay | BirthMonth | BirthYear |
        | <ClientDetailsFieldValue> | John      | A.         | Doe      | 15       | 10         | 1985      |

    And I enter the client details for previous name
        | ClientDetailsFields       | PreviousName             | FirstName | MiddleName | LastName | BirthDay | BirthMonth | BirthYear |
        | <ClientDetailsFieldValue> | add previous name  | John      | A.         | Doe      | 15       | 10         | 1985      |

    And I enter the client name details
        | ChangeClientName   |ChangePreviousName  | DeletePreviosName |AddPreviousNames      | FirstName | MiddleName | LastName |BirthDay | BirthMonth | BirthYear |
        | <ClientName>       |<PreviousName>      |<RemovePreviosName>| <AddPreviousNames>   | Addison   | B.         | Harris   |15       | 11         | 1985      |

    And I enter the Client address 
      | EnterAddressManually   | FindAddress-Postcode   | Postcode | AddressLine1   | AddressLine2 | City       | SpecificAddress                       |
      | <AddressManually>      | <FindAddress-Postcode> | RH6 7HS  | 91 Albert Road |  HORLEY      | Surrey     | 91 Albert Road, HORLEY, Surrey RH6 7HS|
    When I enter the Client address summary page
      | ChangeCurrentAddress      | HideAddress   | AddPreviousAddress  | Postcode | AddressLine1   | AddressLine2 | City       | SpecificAddress                       |
      | <CurrentAddress>          | <HideAddress> | <AddPreviousAddress>|RH6 7HS  | 91 Albert Road |  HORLEY      | Surrey     | 101 Albert Road, HORLEY, Surrey RH6 7HS|
    When I select the debtor contact preference
      | Preference  | Email                | ConfirmEmail         |
      | <Preferences>| test@example.com     | test@example.com     |
    And I provide the debtor business debts details
      | Option   |
      | <Options> |

    And I added the debtor business name and address
       |BusinessName  | ClientBusinessAddress |EnterAddressManually   | FindAddress-Postcode   | Postcode | AddressLine1   | AddressLine2 | City       | SpecificAddress                       |
       |ABC Ltd       | <BusinessAddress>     | <EnterAddressManually> | <FindAddress-Postcode> | RH6 7HS  | 91 Albert Road |  HORLEY      | Surrey     | 91 Albert Road, HORLEY, Surrey RH6 7HS|

    And I update the debtor account summary page
       | UpdateClientName   | UpdateDOB   | UpdateAddPreviousNames   | UpdateCurrentAddress   | UpdateHideAddress   | UpdateAddPreviousAddress   | ChangeNotifications   | UpdateAddBusinessAddress   | UpdateBusinessAddress   | DeleteBusinessAddress   | FirstName | MiddleName | LastName | BirthDay | BirthMonth | BirthYear | Postcode | AddressLine1   | AddressLine2 | City   | SpecificAddress                         | Preference    | ClientBusinessAddress |
       | No                 |No           |  No                     |   No                     | no                  | no                         |  no                     | no                       | no                      |  No                       | John      | A.         | Doe      | 15       | 10         | 1985      | RH6 7HS  | 91 Albert Road | HORLEY       | Surrey | 101 Albert Road, HORLEY, Surrey RH6 7HS | no         |   no                  |
    And I choose to add debt and creditor 
       | CreditorType   | CreditorName          | Postcode   | Preference  | Email                | ConfirmEmail         |DebtType   | DebtAmount   | Reference | 
       | <CreditorType> | Jots Geeten Creditor  | RH6 7HS    |<Preferences>| test@example.com     | test@example.com     |<DebtType> | <DebtAmount> | BSS123 | 
            
    And I updated creditor account summary
       | CreditorName | FindAddress-Postcode   | Postcode | AddressLine1   | AddressLine2 | City   | SpecificAddress                        | DebtType   | Preference   | Email            | ConfirmEmail     |
       | Jots Geeten Creditor | <FindAddress-Postcode> | RH6 7HS  | 91 Albert Road | HORLEY       | Surrey | 91 Albert Road, HORLEY, Surrey RH6 7HS | <DebtType> | <Preferences> | test@example.com | test@example.com |

    And I choose to submit breathing space 
        | SubmitTheBreathingSpace |
        |Yes                      |
    And I Select breathing space Type
        | BreathingSpaceType         | NominatedContactRole   | Fullname | Telephone      | Email            | ConfirmEmail     | ContactPrefrerenceMethod |
        | <SelectBreathingSpaceType> | <NominatedContactRole> | JohnATom | +4408081570192 | test@example.com | test@example.com |  Email                    |

    And I agree declaration and submit to Breathing space
        
    And I Submited Client Breathing Space and generated BSS Client reference number

    And I search for the Breathing Space using the following options
        | BSSReferenceNumber | LastNameDOB |
        | reference          |   lastnameanddob |

    And I validate the breathing space search results
        | MentalHealthTag | BSSStatus |
        | Mental Health   |   Active|


Examples:
  | User          | Organisation          | ClientDetailsFieldValue | ChangeCurrentName | ClientName       | PreviousName       | RemovePreviosName | AddPreviousNames | FindAddress-Postcode | AddressManually      | CurrentAddress      | HideAddress | AddPreviousAddress | Preferences | Options | BusinessAddress   | CreditorType | CreditorName           | DebtAmount | DebtType | SelectBreathingSpaceType | NominatedContactRole |
  | Money Advisor | Manzoor Money Advisor | CheckFieldValidation    |                   |                  |                    |deletePreviousName |                  | EnterPostcode        |                      | ChangeCurrentAddress|             |                    | email       | Yes     | sameashomeaddress | CMP          | Manzoor Test Creditors | 999        | Debt     | Mental Health            |mental health nurse        |
  #| Money Advisor | Manzoor Money Advisor | CheckFieldValidation   |                   |changeCurrentName | changePreviousNam  |                   |                  |                      | EnterAddressManually |                      |             |                    | Post        |         ||
  #| Money Advisor | Manzoor Money Advisor | CheckFieldValidation   |                   |                  |                    |deletePreviousName |                  | EnterPostcode        |                      |                      |             |                    | Post        |         ||
  #| Money Advisor | Manzoor Money Advisor | CheckFieldValidation   |                   |                  |                    |                   | addPreviousNames |                      | EnterAddressManually |                      |             |                    | Post        |         ||


    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    #Feature: EndToEndJourney
#
#A short summary of the feature
#
#Background: Log in to Breathing Space applicaton
#	Given I log into the Breathing Space Application
#
#@UI @UI-E2E
#	Scenario Outline: Start Of Standard BreathingSpace - Add previous name - Change debtor name and Pervious name and address
#	When I navigate to the Breathing Space Homepage as '<User>'
#	
#
#
#
#Examples: 
#	|User                 | previousName | previousAddresses | Notification | emailAddress           | confirmemailAddress    | ClientEligibilityForBSS | creaditorspostcode | creditornotification | submitBSS | wichBSS  |
#	|Manzoor Money Advisor|              | Yes               | Post         | test@insolvency.gov.uk | test@insolvency.gov.uk | Yes                     | RH7 7BS            | Yes                  | Standard  | Standard |
#
#
#
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    #And I add debt type amount and reference

  #    #And I enter the creaditor address
#
#    And I select the creditor contact preference
#      | Preference  | Email                | ConfirmEmail         |
#      | <Preferences>| test@example.com     | test@example.com     |



    #And I enter the debtor another address 
    #  | EnterAddressManually   | FindAddress-Postcode   | Postcode | AddressLine1   | AddressLine2 | City       | SpecificAddress                       |
    #  | <EnterAddressManually> | <FindAddress-Postcode> | RH6 7HS  | 91 Albert Road |  HORLEY      | Surrey     | 91 Albert Road, HORLEY, Surrey RH6 7HS|















#	And I choose to create a Breathing Space
#	And I create new client with details
#	| preference | emailAddress           | firstName   | middleName | lastName    | dateOfBirth | emptyfirstname            | emptylastname            | 
#	| 2          | test@insolvency.gov.uk | Test		 | Auto		  | One         | 1986-03-19  | Enter client's first name| Enter client's last name | 
#	And I click add previous Name 'Yes'
#	And I enter previous name 
#	| firstName  | middleName | lastName | dateOfBirth | emptyfirstname            | emptylastname            |
#	| Joshua     |            | Batess   | 1986-03-19  | Enter client's first name | Enter client's last name |
#	And I verify updated previous name 
#	And I click save and continue on client name summary page
#	And I add client address
#	| Addressline1     | Addressline2   | TownCity         | County           | PostCode | Country | dateFrom   | dateTo     |
#	| addressL1-Prev   | addressL2-Prev | addressTC-Pv     | addressCO-Prev   | 12345    | India   | 1977-12-31 | 1978-12-31 |
#	And I confirm client address on debtor address page 
#	And I set previousAddresses to
#	| prevAddressline1 | prevAddressline2   | prevTownCity         | prevCounty         | prevPostCode | prevCountry | dateFrom   | dateTo     |
#	| addressL1-Prev   | addressL2-Prev     | addressTC-Pv         | addressCO-Prev     | 12345        | India       | 1977-12-31 | 1978-12-31 |
#	And I select client receive confirmation by Email or Post or No Notification
#	And I set business to
#	| businessName | sameAsCurrentHomeAddress | businessaddressline1 | businessaddressline2 | businesstownCity | businesscounty | businesspostCode | businesscountry |
#	| Business-1   |                          |addressL1-Bus-Api    | addressL2-Bus-Api    | addressTC-Bus-Api | addressCO-Bus-Api | RH6 7HS       | United Kingdom  |
#	And I confirm client details on debtor confirm page
#	And I choose to add debt and submit debt with the details below
#	| creditorId | debtTypeId | cmpReference | cmpNino   | cmpAmount | cmpDebtTypeName |
#	| TEST DWP   | Mortgage   | NotifyViaApi | AA123456C | 123.40    | Mortgage        |
#	And I submit the client into Breathing space
#	And I select standard Breather space
#	And I agree declaration and submit to Breathing space
#	And I verify client reference no

#	And I wait for debt status to become 'Active - New Debt'

#	| Yes          | Yes              | Post        | test@insolvency.gov.uk | test@insolvency.gov.uk | Yes                     | RH7 7BS            | Yes                  | Mental Health |          |
#	| No           | No               | Email       | test@insolvency.gov.uk | test@insolvency.gov.uk | YeS                     | RH7 7BS            | Yes                  | Standard      |          |
#	| No           | No               | Email       | test@insolvency.gov.uk | test@insolvency.gov.uk | Yes                     | RH7 7BS            | Yes                  | Mental Health |          |
#	| Yes          | Manual           | Email       | test@insolvency.gov.uk | test@insolvency.gov.uk | Yes                     | RH7 7BS            | Yes                  | Mental Health |          |










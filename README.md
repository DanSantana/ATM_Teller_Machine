# ATM_Teller_Machine
C# Development, ATM Teller Machine simulator

The present project aims to demonstrate the skills and knowledge acquired until the present moment in the programming course.
This project simulates the first work day in the consulting company, as a programmer.
The main task received consists in a development of a new prototype application that simulates the operation of an automatic Teller Machine.
 Applying a graphical interface and also allowing the practice of a lot of items already used and previous studied the main objective are listed below:
•	Interpret specification and analysis performed;
•	Design a solution based on the requirements and specification;
•	Design the logic required for and event-driven solution;
•	Translate design documents and algorithms into source code;
•	Read from and write to a file;
•	Use debugging tools, and error-handling techniques;
•	Validate the solution with test data;
•	Integrate the knowledge’s acquired thus far;
•	Have fun while programming with visual studio C#.net

2. Project Description
Based in the current version as “demo interface will be developed a new system and interface to deal with transactions of automatic Teller Machine. 
2.1 Business Requirement Resume
General Description: “After successfully completing your studies, you have landed the job of your dreams with a consulting firm. Today is your first day on the job as a junior programmer. Your immediate supervisor gives you the responsibility to develop an application prototype that simulates the operation of an automatic teller machine (ATM). The client is running an older version and would like it updated. Your supervisor is expecting you to deliver a functioning prototype in six days. This is your opportunity to showcase your creative talents, and your analysis, design, coding, and testing abilities.
2.2 Function and Features:
2.2.1 Login: Before performing any transaction, the user must enter his or her name and on an input screen. Since the operation of this input screen should simulate the normal operation of an ATM, the PIN should not appear on the screen. In addition to the message which appears after every unsuccessful attempt, if after three tries the PIN matching the name has not been entered, the application should display a message requesting the user to try using the ATM again later. The names and PINs of users must be validated using data contained in the Customers.txt text file having the following structure:
•	name (String)
•	PIN (String – 4 characters)
2.2.2 Main Form: Once access has been authorized, the main form of the application should allow the user to carry out one of the following transactions:
•	Deposit
•	Withdrawal
•	Transfer
•	Bill payment
Below is the structure of the Accounts.txt sequential file in which account balances are stored: 
•	Account type (1 character) 
•	Pin (string – 4 characters) 
•	Account number (string – 5 characters) 
•	Account balance (single Decimal)
2.2.3 Deposit: For a deposit, the user must enter the amount and, if required, be able to select the account type to be credited. The checking account is the default for this transaction.
2.2.4 Withdrawal: For a withdrawal, the user must enter the amount and, if required, be able to select the account type to be debited. The checking account is the default for this transaction subject to a maximum of $1,000. The ATM accepts only transactions for which the amount entered is a multiple of $10. There is no daily maximum amount (apart from the user’s account balance).
2.2.5 Transfer: For a transfer, the user must enter the amount and the type of transfer (from checking to savings, or vice versa). This transaction is subject to a maximum $100,000. The system must allow only a transfer from checking to savings, or from savings to checking.
2.2.6 Bill Payment: For a bill payment, which is done from a checking account only, the user must enter the amount of the transaction. The checking account is debited by the same amount. In addition, a $1.25 fee is charged to the checking account. The maximum per transaction is $10,000.
3. General Rules
3.1 Chose Account: When a user performs an operation, the application should first ask if it should be done using a checking or savings account, and then ask for the transaction amount.
3.2 Check Account Balance: The application must check the account balance before doing a transaction. Any transaction that would result in a negative balance must be rejected.
3.3 Update Account Balance: The balance of the account affected by a transaction should be updated and displayed after each transaction.
3.4 Multi transaction: The user should be able to do as many transactions as he or she would like to do before leaving the ATM.
3.4 No Money: A warning message should inform the user that the ATM can no longer carry out withdrawals when there is no money available. When a withdrawal transaction event occurs for an amount greater than the balance remaining in the ATM, the ATM should advise the user they can charge the transaction amount to the amount still available in the user’s account.
3.5 Daily Refilled: When the application is initiated at start of each day, the bank’s balance money is automatically refilled with up to $5,000 for a maximum of $20,000.

4. System Administrator
The system administrator, as any other user, must enter his or her name and PIN (personal identification number) on the same input screen. The system administrator may perform only system transactions (he or she has no personal account).
The supervisor can cause interest to be paid to all savings accounts at the rate of 1% (Balance * rate/365/100).
Once access has been authorized, a special menu is displayed. This menu offers the following options:
•	Pay interest 
•	Refill the ATM with money
•	Take the ATM out of service 
•	Print the accounts report
The system administrator puts in more money in batches of $5,000. There should not be more than $20,000 available in the ATM.

6.	Conclusion

Through the integration project, it was possible to practice important learning acquired until the present moment. Also, engage the theory building a programming application closer to the real world with visual Studio and C Sharp console application in additional with programming and logical design, programming fundamentals, system analysis design.
Overall, the utilization of Programming Object Oriented, in addition to better organize the software structure, provides a better reading of them in the self-niche, minimize errors while improving the quality and the speed in debug the software.
The system.io stream reader provides a powerful feature in order to keep some information in the system, using a simple and fast way.
	The Windows Form Application provides a robust and Simple implementation front edge appliance and it becomes a great way to build a form to be used by any kind systems.
Programming Object Oriented can be perceived as a potential method in order to reduce spending in the construction and maintenance of the system proposed, rising up the algorithm to a level near to the reality without losing security of data.


# PersonalBudgeter
A lightweight personal budgeter program

The application tracks the amount of money spent on each of 4 categories, the remaining amount in the budget, and the 
remaining amount the user can spend in the current week without going over budget.

The application has the user input the total budget amount and the end date of the budget period on opening the 
application for the first time.  This data is serialized and saved into the file "data.xml" in the same directory as 
the application and should not be moved relative to the application.  If the data file is not present in the same 
directory, the budget and end date input will be triggered again, allowing for a 

Note: the first week of the budget will be less than 7 days if the period for the budget does not divide into even weeks.
      However, the first week is given equal weight as the subsequent weeks, despite it being possibly shorter.
      
The application allows the user to enter reciept amounts and designate each reciept as one of the four categories.  
The reciept entry text field permits negative values, allowing for corrections of erroneous reciept entry.

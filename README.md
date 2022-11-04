# GildedRose

##############  Dependency ###################

To execute this code we need DotNet Framework 4.8 and Visual Studio.

############  Steps to run the code. ###############

Clone this repository to local folder.
Once repository is cloned open solution file (csharp.sln) in Visual studio(VS).
Build the solution using the build option in VS
Run the application using Debug - > Strat without debugging. option  or Click on Start button in VS
Console will open with output.

####################### Output format #################

Output we can see all items their sellin value and quality till next 30 days.

----------- day 0 ------------
Item     SellIn      Quality
aaa      9           10
.
.
----------- day 1 -----------
Item     SellIn      Quality
aaa      8           11
.
. and so on

Incase of exception it will write exception message in console.

#######################  DataChange ####################

In order to test different datasets you can stop  the program (Close the console), add items or modify
values in Program.cs file and run the program again.


################# Unit Test ######################

I also have unit test added to this project 
I have used xunit for unit testing

To run Unit test you can go to TestExplorer -> RunAllTests in Visula studio




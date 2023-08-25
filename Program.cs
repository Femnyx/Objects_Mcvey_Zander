// See https://aka.ms/new-console-template for more information
using Objects_Mcvey_Zander;

//Makes this a reference and adds onto the statements "Brand," "Type," and if it "IsOn," on boot up
Computer myComputer = new Computer("Apple", "All-in-One", true);
IBootUp myBootUp = myComputer;
Console.WriteLine(myComputer.Equals(myBootUp));

//Makes this another reference, different from the one before as it does it for myOtherComputer.
Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
Console.WriteLine(myComputer.Equals(myOtherComputer));

//myString equals myComputer and turns it into a string and equals myOtherString to myString
string myString = myComputer.ToString();
string myOtherString = myString;

//Opens up with the "Computer" saying "Hi!"
myString = "Hi!";

//Writes the line stored in myString and myOtherString.
Console.WriteLine(myString);
Console.WriteLine(myOtherString);

//Makes the myString equal to myComputer and myOtherComputer.
Console.WriteLine(myString == myComputer.ToString());
Console.WriteLine(myString == myOtherComputer.ToString());

//Writes the sentence stored in myComputer and myBootUp while getting the type.
Console.WriteLine(myComputer.GetType());
Console.WriteLine(myBootUp.GetType());

//Makes "myOtherComputer" with the PowerOnOff command, seeing if it will turn on or shut down.
myOtherComputer.PowerOnOff();

//Writes the line for myString and equals the variable to myOtherComputer.
Console.WriteLine(myString == myOtherComputer.ToString());
Console.WriteLine(myString);
Console.WriteLine(myOtherComputer.ToString());

//The string contains the variable/letter "i" in the sentence.
Console.WriteLine(myString.Contains('i'));

//Turns the string uppercase.
Console.WriteLine(myString.ToUpper());

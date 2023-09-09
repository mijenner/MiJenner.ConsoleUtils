# MiJenner.ConsoleUtils
ConsoleUtils offer cross-platform utilities for easy interaction with a user. 

There are methods for persistent reading of values of a certain data type from the console user. Pattern is ```cs Read<datatype>()````. They prompt the user, and keep asking user for a value of a certain data type until she/he enters a correct data type. It offers methods for integers, doubles, decimals, boolean, dates, and enums. 

There is a method for reading in multiple lines of text from the user ```StringReadMultipleLines```. 

There are methods for removing non-letters from strings: ```cs StringRemoveNonLettersENG(...)``` and ```cs StringRemoveNonLettersAll(...)```. 

Finally there are methods for opening file explorer in current directory ```cs OpenExplorerFinder()```

# Method Signatures 

Below is listed the signatures of the methods: 
* ```cs public static void OpenExplorerFinder()```
* ```cs public static void OpenExplorerFinderPath(string folderPath)```
* ```cs public static int ReadInt(string prompt, string errorMessage)```
* ```cs public static double ReadDouble(string prompt, string errorMessage)```
* ```cs public static decimal ReadDecimal(string prompt, string errorMessage)```
* ```cs public static bool ReadBoolean(string prompt, string errorMessage, string trueValue = "j", string falseValue = "n")```
* ```cs public static DateTime ReadDate(string prompt, string errorMessage)```
* ```cs public static T ReadEnum<T>(string prompt, string errorMessage) where T : struct, Enum```
* ```cs public static string StringRemoveNonLettersENG(string input)```
* ```cs public static string StringRemoveNonLettersAll(string input)```
* ```cs public static string StringReadMultipleLines(string prompt, string instruction = "Type 3 empty lines to end")```

# Examples 
Below are examples on how the library can be used: 
```cs 
ConsoleUtils.OpenExplorerFinder();
ConsoleUtils.OpenExplorerFinderPath("."); 
var a = ConsoleUtils.ReadInt("Please provide an integer", "No, please provide an integer");
var b = ConsoleUtils.ReadDouble("Please provide a floating point number", "No, please provide a floating point number");
var c = ConsoleUtils.ReadDate("Please provide a date", "No, please provide a date");
var d = ConsoleUtils.ReadBoolean("Please provide a boolean", "No, please provide a boolean", "t", "f");
var e = ConsoleUtils.ReadEnum<MyEnum>("Please provide an enum, MyEnum", "No, please provide an enum, MyEnum");
```

# Nuget package 
There is a nuget package available for easy usage. 






* 

using MiJenner;
using System;
using System.Collections.Generic;

namespace UsageExamples
{
    public enum MyEnum { Val1, Val2, Val3 }
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtils.OpenExplorerFinder();

            // ConsoleUtils.OpenExplorerFinderPath(".");

            var a = ConsoleUtils.ReadBoolean("Please provide a boolean", "No, please provide a boolean", "t", "f");

            var b = ConsoleUtils.ReadDate("Please provide a date", "No, please provide a date");

            var c = ConsoleUtils.ReadDouble("Please provide a floating point number", "No, please provide a floating point number");

            var d = ConsoleUtils.ReadEnum<MyEnum>("Please provide an enum, MyEnum", "No, please provide an enum, MyEnum");

            var e = ConsoleUtils.ReadInt("Please provide an integer", "No, please provide an integer");

            string[] stringsArray = { "Left", "Right", "Up" };
            var f = ConsoleUtils.ReadStringFromArray("Type a string from ", "No", stringsArray);

            List<string> stringsList = new List<string> { "Left", "Right", "Up" };
            var g = ConsoleUtils.ReadStringFromList("Type a string from ", "No", stringsList);

            var choicesString = new Dictionary<string, string>
            {  {"Left", "Option 1" }, {"Right", "Option 2" }, {"Back", "Option 3" } };

            var h = ConsoleUtils.ReadDictKey<string, string>("Type dict key (string)", "Nope", choicesString);

            var choicesInt = new Dictionary<int, string>
            { {1, "Option 1" }, {2, "Option 2" }, {3, "Option 3" } };

            var i = ConsoleUtils.ReadDictKey<int, string>("Type dict key (int)", "Nope", choicesInt);

            string text = "Here is some text";
            Console.WriteLine("Original text : " + text);
            Console.Write("Edit the text : ");
            text = ConsoleUtils.ReadLineWithEdit(text);
            Console.WriteLine("After editing : " + text);

        }
    }
}

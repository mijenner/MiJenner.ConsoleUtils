using System;
using MiJenner; 

namespace UsageExamples
{
   enum MyEnum { Val1, Val2, Val3 }

   internal class Program
   {
      MyEnum myEnum; 

      static void Main(string[] args)
      {
         ConsoleUtils.OpenExplorerFinder();

         ConsoleUtils.OpenExplorerFinderPath("."); 

         var a = ConsoleUtils.ReadInt("Please provide an integer", "No, please provide an integer");

         var b = ConsoleUtils.ReadDouble("Please provide a floating point number", "No, please provide a floating point number");

         var c = ConsoleUtils.ReadDate("Please provide a date", "No, please provide a date");

         var d = ConsoleUtils.ReadBoolean("Please provide a boolean", "No, please provide a boolean", "t", "f");

         var e = ConsoleUtils.ReadEnum<MyEnum>("Please provide an enum, MyEnum", "No, please provide an enum, MyEnum");

      }
   }
}

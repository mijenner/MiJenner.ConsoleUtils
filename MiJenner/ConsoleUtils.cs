using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace MiJenner
{
   public class ConsoleUtils
   {
      public static void OpenExplorerFinder()
      {
         // Get the output directory of the project
         string outputDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
         if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
         {
            Process.Start(new ProcessStartInfo()
            {
               FileName = "explorer.exe",
               Arguments = outputDir
            });
         }
         else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
         {
            Process.Start("open", outputDir);
         }
         else
         {
            throw new PlatformNotSupportedException("Opening file explorer is not supported on this platform.");
         }
      }

      public static void OpenExplorerFinderPath(string outputDir)
      {
         if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
         {
            Process.Start(new ProcessStartInfo()
            {
               FileName = "explorer.exe",
               Arguments = outputDir
            });
         }
         else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
         {
            Process.Start("open", outputDir);
         }
         else
         {
            throw new PlatformNotSupportedException("Opening file explorer is not supported on this platform.");
         }
      }

      public static int ReadInt(string prompt, string errorMessage)
      {
         int result;
         while (true)
         {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out result))
            {
               return result;
            }
            Console.WriteLine(errorMessage);
         }
      }

      public static double ReadDouble(string prompt, string errorMessage)
      {
         double value;
         string input;

         CultureInfo culture = Thread.CurrentThread.CurrentCulture;

         NumberStyles style = NumberStyles.Float | NumberStyles.AllowLeadingSign
            | NumberStyles.AllowDecimalPoint;

         while (true)
         {
            Console.Write(prompt);
            input = Console.ReadLine();

            if (double.TryParse(input, style, culture, out value))
            {
               return value;
            }
            else
            {
               Console.WriteLine(errorMessage);
            }
         }
      }

      public static bool ReadBoolean(string prompt, string errorMessage, string trueValue = "j",
         string falseValue = "n")
      {
         while (true)
         {
            Console.Write(string.Format("{0} ({1} / {2}) ", prompt, trueValue, falseValue));
            string input = Console.ReadLine().ToLower();
            if (input == trueValue || input == falseValue)
            {
               return input == trueValue;
            }
            string strError = string.Format("{0} ({1} / {2})", errorMessage, trueValue, falseValue);
         }
      }

      public static DateTime ReadDate(string prompt, string errorMessage)
      {
         DateTime value;
         string input;

         CultureInfo culture = Thread.CurrentThread.CurrentCulture;
         string dateFormat = culture.DateTimeFormat.ShortDatePattern;
         dateFormat = dateFormat.Replace("ddd ", "");

         while (true)
         {
            Console.Write(string.Format("{0} ({1}): ", prompt, dateFormat));
            input = Console.ReadLine();

            if (DateTime.TryParseExact(input, dateFormat, culture, DateTimeStyles.None, out value))
            {
               return value;
            }
            else
            {
               Console.WriteLine(string.Format("{0} ({1}): ", errorMessage, dateFormat));
            }
         }
      }

      public static T ReadEnum<T>(string prompt, string errorMessage) where T : struct, Enum
      {
         while (true)
         {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (Enum.TryParse<T>(input, ignoreCase: true, out T result))
            {
               return result;
            }
            else
            {
               Console.WriteLine(errorMessage);
            }
         }
      }

      public static string StringRemoveNonLettersENG(string input)
      {
         string temp;
         temp = Regex.Replace(input, @"[^a-zA-Z0-9]", "");
         return temp.Trim();
      }

      public static string StringRemoveNonLettersAll(string input)
      {
         string temp;
         temp = Regex.Replace(input, @"[^\p{L}]", "");
         return temp.Trim();
      }

      public static string StringReadMultipleLines(string prompt, string instruction = "Indtast 3 tomme linjer for at slutte")
      {
         Console.WriteLine(prompt);
         Console.WriteLine(instruction);
         string userInput = "";
         int emptyLineCount = 0;
         while (true)
         {
            string line = Console.ReadLine();
            if (line == "")
            {
               userInput += line + "\n";
               emptyLineCount++;

               if (emptyLineCount > 2)
               {
                  userInput = userInput.Remove(userInput.Length - 3);
                  break;
               }
            }
            else
            {
               userInput += line + "\n";
               emptyLineCount = 0;
            }
         }

         return userInput;
      }
   }
}

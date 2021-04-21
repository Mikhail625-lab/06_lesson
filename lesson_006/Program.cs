using System;

/*
ver: 0.1a date: 2021.__.__
autor: Mikhail625@protonmail.com
*/

namespace lesson_006
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureConsole(" Lesson #6   ver: 0.1a date: 2021.04.18");
            // Task01();
            // Task02();
            // Task03();
            // Task04();
            // Task05();


            { // Task № 01
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            { // Task № xx
              // block declare init vars
              // block executive
              // end of  Task № xx
            }

            // under

            static string GetStrFromCons(string strQuestion, string strByDef)
            {
                string strResult;
                if (TestForNullOrEmpty(strQuestion) == true)
                { strQuestion = "   Enter value:"; }

                Console.WriteLine("   " + strQuestion);
                //Console.ForegroundColor = ConsoleColor.DarkYellow;
                strResult = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;

                // check/verife isNull Empty
                if (TestForNullOrEmpty(strResult) == true)
                {
                    strResult = strByDef;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("       " + "Not value, set by default: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(strResult);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("");

                }
                return strResult;
            }

            static bool TestForNullOrEmpty(string s)
            {
                bool result;
                result = (s == null || s == string.Empty);
                return result;
            }

            static void ClearScr(int countDown, int warningTimer)
            {
                bool bWarning = false;

                for (int i = (countDown + 1); i > 0; i--)
                {
                    System.Threading.Thread.Sleep(1000);
                    if (i == warningTimer) { bWarning = true; }
                    if (bWarning == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\r         ");
                    Console.Write("\r     [{0}]", i);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();



            }

            static void ConfigureConsole(string headerConsWindow)
            {
                // Configure console.
                Console.Title = headerConsWindow;
                /*
                 * Console.BufferWidth = 80;
                Console.WindowWidth = Console.BufferWidth;
                Console.TreatControlCAsInput = true;

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                */
            }



        }
    }
}

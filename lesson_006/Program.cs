using System;
using System.Threading;
using System.Threading.Tasks;

/*
ver: 0.1a date: 2021.__.__
autor: Mikhail625@protonmail.com
*/
/*
 1. Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
2. Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4,

при подаче массива другого размера необходимо бросить исключение MyArraySizeException.
Далее метод должен пройтись по всем элементам массива, преобразовать в int, и просуммировать.
Если в каком-то элементе массива преобразование не удалось
(например, в ячейке лежит символ или текст вместо числа), должно быть брошено исключение MyArrayDataException, с детализацией в какой именно ячейке лежат неверные данные.
В методе main() вызвать полученный метод, обработать возможные исключения MySizeArrayException и MyArrayDataException, и вывести результат расчета.

*/

namespace lesson_006
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureConsole(" Lesson #6   ver: 0.1a date: 2021.04.18");
             Task01();
            // Task02();
            // Task03();
            // Task04();
            // Task05();

            static void Task01()
            { // Task № 01
              // block declare init vars
              // block executive
                System.Diagnostics.Process[] processes;
                processes = System.Diagnostics.Process.GetProcesses();
                foreach (System.Diagnostics.Process instance in processes)
                {
                    //listBox1.Items.Add(instance.ProcessName); // id  ProcessssName

                    Console.WriteLine("PID:   {0}   ProcessssName: {1} ", processes.id);
                    //processes.

                }
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

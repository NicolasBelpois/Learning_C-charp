using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDessin
{
    class Program
    {
       
            public static void Main()

            {

                char cLight = Encoding.GetEncoding(850).GetChars(new byte[] { 176 })[0];

                char cDark = Encoding.GetEncoding(850).GetChars(new byte[] { 177 })[0];

                char cDarkLight = Encoding.GetEncoding(850).GetChars(new byte[] { 178 })[0];


                DessinerHerbe(cLight);

                DessinerMaison(cDark);

                DessinerToit(cDark);

                DessinerPorte(cDarkLight);


                Console.ResetColor();

                Console.SetCursorPosition(0, 20);

                Console.CursorVisible = false;

                Console.ReadKey(true);

            }


            private static void DessinerPorte(char cDarkLight)

            {

                Console.BackgroundColor = ConsoleColor.Red;

                for (int j = 0; j < 3; j++)

                {

                    Console.SetCursorPosition(33, 11 + j);

                    for (int i = 0; i < 4; i++)

                    {

                        Console.Write(cDarkLight);

                    }

                }

            }


            private static void DessinerToit(char cDark)

            {

                Console.BackgroundColor = ConsoleColor.DarkRed;

                for (int i = 0; i < 6; i++)

                {

                    Console.SetCursorPosition(35 + i, i + 2);

                    Console.Write(cDark);

                    Console.SetCursorPosition(35 - i, i + 2);

                    Console.Write(cDark);

                }

            }


            private static void DessinerMaison(char cDark)

            {

                Console.BackgroundColor = ConsoleColor.DarkMagenta;

                for (int j = 0; j < 7; j++)

                {

                    Console.SetCursorPosition(30, 7 + j);

                    for (int i = 0; i < 11; i++)

                    {

                        Console.Write(cDark);

                    }

                }

            }


            private static void DessinerHerbe(char cLight)

            {

                Console.SetCursorPosition(0, 10);

                Console.BackgroundColor = ConsoleColor.Green;

                for (int j = 0; j < 10; j++)

                {

                    for (int i = 0; i < Console.WindowWidth; i++)

                    {

                        Console.Write(cLight);

                    }

                }

            }
        }
    }


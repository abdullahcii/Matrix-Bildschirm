using System;

namespace Matrix_Bildschirm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Textfarbe einstellen
            Console.ForegroundColor = ConsoleColor.Green;

            //Random Nummer
            Random rand = new Random();

            String str = "";

            Console.Write("Drücken Sie zum Starten Enter.... ");
            Console.ReadKey();

            for (int i = 0; i < 20000; i++)
            {

                if(i % 2 == 0)
                {
                    str = "";
                    for (int j = 0; j < 79; j++)
                    {
                        int n = rand.Next(5);
                        if (n < 2)
                        {
                            str += n.ToString();
                        }
                        else
                        {
                            str += " ";
                        }
                    }
                }


                Console.WriteLine(str);
            }

            Console.WriteLine("Ende");
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}

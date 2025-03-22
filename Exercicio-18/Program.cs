using Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool onMenu, seeOdd;
            do
            {
                Header();

                seeOdd = Validators.YesOrNo("\nDeseja ver quais são os números? (S/N) ");
                if (seeOdd == true)
                    OddNumbersGenerator();
                else
                    break;

                    onMenu = Validators.YesOrNo("\n\nDeseja continuar? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($"  Gerador de Ímpares de 100 a 200 | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static void OddNumbersGenerator()
        {
            Header();
            Console.Write("\n| ");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                    ViewUtils.PaintWrite($"{i.ToString()} | ");
            }
        }
    }
}

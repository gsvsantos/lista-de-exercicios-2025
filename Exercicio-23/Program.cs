using Utils;

namespace Exercicio_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool onMenu, seeFizzBuzz;
            do
            {
                Header();
                seeFizzBuzz = Validators.YesOrNo("\nQuer ver o que é o FizzBuzz?? >:D (S/N) ");
                if (seeFizzBuzz == true)
                    FizzBuzz();
                else
                    break;

                onMenu = Validators.YesOrNo("\nDeseja ver novamente? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Então... Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($"  FizzBuzz - 1 a 100 || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==\n", ConsoleColor.Cyan);
        }
        static void FizzBuzz()
        {
            Header();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    ViewUtils.PaintWrite($"{i} - Fizz", ConsoleColor.DarkRed);
                    ViewUtils.PaintWrite("Buzz\n", ConsoleColor.White);
                }
                else if (i % 3 == 0)
                {
                    ViewUtils.PaintWriteLine($"{i} - Fizz", ConsoleColor.Red);
                }
                else if (i % 5 == 0)
                {
                    ViewUtils.PaintWriteLine($"{i} - Buzz", ConsoleColor.White);
                }
            }
        }
    }
}

using Utils;

namespace Exercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool onMenu, seeOddSum;
            do
            {
                Header();

                seeOddSum = Validators.YesOrNo("\nDeseja ver qual o resultado da soma? (S/N) ");
                if (seeOddSum == true)
                    OddNumbersSum();
                else
                    break;

                onMenu = Validators.YesOrNo("\nDeseja ver novamente? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($"  Soma dos Ímpares de 1 a 500 | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static void OddNumbersSum()
        {
            int sumTotal = 0;

            Header();
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    sumTotal += i;
                }
            }
            ViewUtils.PaintWriteLine($"A soma total é: {sumTotal}");
        }
    }
}

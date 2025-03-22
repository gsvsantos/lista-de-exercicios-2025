using System.Diagnostics;
using Utils;

namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber, thirdNumber;
            bool onMenu;
            do
            {
                Header();
                firstNumber = Validators.DoubleVerify("Digite o valor de A: ");
                secondNumber = Validators.DoubleVerify("Digite o valor de B: ");
                thirdNumber = Validators.DoubleVerify("Digite o valor de C: ");

                DescendingOrganizer(firstNumber, secondNumber, thirdNumber);

                onMenu = Validators.YesOrNo("\nDeseja fazer outro cálculo? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($"  Organizador de Valores Inteiros | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static void DescendingOrganizer(double firstNumber, double secondNumber, double thirdNumber)
        {
            double[] numbers = { firstNumber, secondNumber, thirdNumber };
            for (int i = 0; i < numbers.Length; i++)
            {
                double highestNumber = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] > highestNumber)
                    {
                        highestNumber = numbers[j];
                    }
                }
                ViewUtils.PaintWriteLine(highestNumber.ToString());
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == highestNumber)
                    {
                        numbers[j] = 0;
                        break;
                    }
                }
            }
        }
    }
}

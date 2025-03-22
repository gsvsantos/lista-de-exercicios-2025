using Utils;

namespace Exercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool onMenu;
            do
            {
                Header();
                number = Validators.IntVerify("Digite um número: ");
                FibonacciCalc(number);
                onMenu = Validators.YesOrNo("\n\nDeseja ver novamente? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($"  Calculadora - Fibonacci | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==\n", ConsoleColor.Cyan);
        }
        static void FibonacciCalc(int number)
        {
            int pastValue = 0;
            int actualValue = 1;

            ViewUtils.PaintWrite($"|");
            while (pastValue <= number)
            {
                ViewUtils.PaintWrite($" {pastValue} |");
                int nextValue = pastValue + actualValue;
                pastValue = actualValue;
                actualValue = nextValue;
            }
        }
    }
}

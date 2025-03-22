using Utils;

namespace Exercicio_21
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
                FactorialCalc(number);
                onMenu = Validators.YesOrNo("\nDeseja ver novamente? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($"  Calculadora - Fatorial || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==\n", ConsoleColor.Cyan);
        }
        static void FactorialCalc(int number)
        {
            int factorial = 1;
            Header();
            for (int i = number; i > 1; i--)
            {
                factorial *= i;
            }

            ViewUtils.PaintWriteLine($"O resultado de {number}! é: {factorial}");
        }
    }
}

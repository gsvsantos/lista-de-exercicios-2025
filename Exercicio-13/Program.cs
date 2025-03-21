using Utils;

namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valueA, valueB, valueC;
            bool onMenu;
            do
            {
                Header();
                valueA = Validators.DoubleVerify("Digite o valor de A: ");
                valueB = Validators.DoubleVerify("Digite o valor de B: ");
                valueC = Validators.DoubleVerify("Digite o valor de C: ");

                WhoIsBigger(valueA, valueB, valueC);

                onMenu = Validators.YesOrNo("\nDeseja fazer outro cálculo? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Validador - Qual é maior? | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static void WhoIsBigger(double valueA, double valueB, double valueC)
        {
            if ((valueA + valueB) < valueC)
            {
                ViewUtils.PaintWriteLine($"\nO valor de C ({valueC}) é o maior =)", ConsoleColor.Green);
            }
            else
                ViewUtils.PaintWriteLine($"\nO valor de C ({valueC}) não é o maior =/", ConsoleColor.Red);
        }
    }
}

using Utils;

namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber, result;
            bool onMenu;
            do
            {
                Header();
                firstNumber = Validators.DoubleVerify("Digite o primeiro número: ");
                secondNumber = Validators.DoubleVerify("Digite o segundo número: ");
                result = Result(firstNumber, secondNumber);

                ViewUtils.PaintWriteLine($"Com esses valores, o resultado é: {result:F2}", ConsoleColor.Green);

                onMenu = Validators.YesOrNo("\nDeseja continuar? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Calculadora - Soma ou Multiplica || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static double Result(double firstNumber, double secondNumber)
        {
            double calc;
            if (firstNumber == secondNumber)
            {
                calc = firstNumber + secondNumber;
            }
            else
            {
                calc = firstNumber * secondNumber;
            }
            return calc;
        }
    }
}

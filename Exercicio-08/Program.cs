using Utils;

namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool onMenu;
            bool isPrime;
            do
            {

                Header();
                number = Validators.IntVerify("Digite um número para verificar: ");
                isPrime = NumberIsPrimeVerify(number);
                if (isPrime)
                    ViewUtils.PaintWriteLine($"\nO número '{number}' é primo.", ConsoleColor.Green);
                else
                    ViewUtils.PaintWriteLine($"\nO número '{number}' é não primo.", ConsoleColor.Red);

                onMenu = Validators.YesOrNo("\nDeseja fazer outro cálculo? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Validador - Número Primo || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static bool NumberIsPrimeVerify(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

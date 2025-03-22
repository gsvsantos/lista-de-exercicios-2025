using Utils;

namespace Exercicio_16
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
                OddOrEven(number);

                onMenu = Validators.YesOrNo("\nDeseja continuar? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Validador - Par ou Ímpar || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static void OddOrEven(int number)
        {
            if (number % 2 == 0)
                ViewUtils.PaintWriteLine($"\n{number} é par.", ConsoleColor.Green);
            else
                ViewUtils.PaintWriteLine($"\n{number} é ímpar.", ConsoleColor.Red);
        }
    }
}

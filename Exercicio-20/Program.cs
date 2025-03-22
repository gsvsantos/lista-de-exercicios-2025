using Utils;

namespace Exercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number;
            bool onMenu = true;
            do
            {
                Header();
                number = Validators.DecimalVerify("Digite um número: ");
                if(number >= 1 && number <= 10)
                MultiplicationTable(number);
                else
                {
                    ViewUtils.PaintWriteLine("\nEscolha um número de 1 a 10..\n", ConsoleColor.Red);
                    ViewUtils.PressEnter("TENTAR-NOVAMENTE");
                    continue;
                }
                onMenu = Validators.YesOrNo("\nDeseja ver novamente? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Calculadora - Tabuada até 10 || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==\n", ConsoleColor.Cyan);
        }
       static void MultiplicationTable(decimal number)
        {
            Header();
            for (int i = 1; i <= 10; i++)
            {
                decimal result = number * i;
                ViewUtils.PaintWriteLine($"{number} x {i} = {result}", ConsoleColor.White);
            }
        }
    }
}

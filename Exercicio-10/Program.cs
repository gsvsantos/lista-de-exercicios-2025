using Utils;

namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal frenchBreadSold, broaBreadSold, total;
            bool onMenu = true;
            do
            {
                Header();
                frenchBreadSold = Validators.DecimalVerify("Quantos pães foram vendidos hoje? ");
                broaBreadSold = Validators.DecimalVerify("Quantas broas foram vendidas hoje? ");
                total = Result(frenchBreadSold, broaBreadSold);
                if(total == 0)
                {
                    ViewUtils.PaintWriteLine("\nHoje a venda foi fraquíssima =/\n", ConsoleColor.Red);
                    ViewUtils.PressEnter("CONTINUAR");
                    continue;
                }

                ViewUtils.PaintWriteLine($"\nHotpão arrecadou R$ {total:F2} hoje.", ConsoleColor.Green);
                ViewUtils.PaintWriteLine($"É recomendado guardar R$ {(total * 0.10m):F2} em uma conta poupança!", ConsoleColor.Green);

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
            ViewUtils.PaintWriteLine($" Calculadora - Hotpão || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static decimal Result(decimal frenchBreadSold, decimal broaBreadSold)
        {
            return (frenchBreadSold * 0.12m) + (broaBreadSold * 1.50m);
        }
    }
}

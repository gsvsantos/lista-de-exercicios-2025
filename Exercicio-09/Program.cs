using Utils;

namespace Exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal lenght, width, area;
            bool onMenu;
            do
            {
                Header();
                lenght = Validators.DecimalVerify("Digite o comprimento em cm: ");
                width = Validators.DecimalVerify("Digite a largura em cm: ");
                area = Result(lenght, width);

                ViewUtils.PaintWriteLine($"A área desse terrêno é de {area}cm²", ConsoleColor.Green);

                onMenu = Validators.YesOrNo("\nDeseja fazer outro cálculo? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);

        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Calculadora - Área de Terreno | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static decimal Result(decimal lenght, decimal width)
        {
            return lenght * width;
        }
    }
}

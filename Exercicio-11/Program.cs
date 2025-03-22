using Utils;

namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, daysLived;
            bool onMenu;
            do
            {
                Header();
                ViewUtils.PaintWrite("Digite seu nome: ");
                name = Validators.StringVerify("Tem certeza que esse é seu nome?", 2);
                age = Validators.IntVerify("Qual a sua idade? ");
                daysLived = Result(age);

                if (daysLived <= 2555)
                {
                    ViewUtils.PaintWriteLine($"\n Então, {name}.. Você não deveria estar aqui...\n", ConsoleColor.Red);
                    onMenu = false;
                    continue;
                }
                else
                    ViewUtils.PaintWriteLine($"\n{name}, você já viveu {daysLived} dias!!", ConsoleColor.Green);

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
            ViewUtils.PaintWriteLine($"  Calculadora - Dias Vividos || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static int Result(int age)
        {
            return age * 365;
        }
    }
}

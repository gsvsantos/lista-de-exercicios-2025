using Utils;

namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal initialSalary, increasedSalary, finalSalary;
            bool onMenu;
            do
            {
                Header();
                initialSalary = Validators.DecimalVerify("Digite o salário do funcionário: ");
                increasedSalary = SalaryIncrease(initialSalary);
                finalSalary = SalaryDecrease(increasedSalary);


                if (finalSalary == 0)
                {
                    ViewUtils.PaintWriteLine($"\nFuncionário acabou sem nada...\n", ConsoleColor.Red);
                    onMenu = false;
                    continue;
                }
                else
                {
                    ViewUtils.PaintWriteLine($"\nRESULTADO:", ConsoleColor.Green);
                    ViewUtils.PaintWriteLine($"\nSalário inicial: R$ {initialSalary:F2}", ConsoleColor.Green);
                    ViewUtils.PaintWriteLine($"\nSalário após Aumento: R$ {increasedSalary:F2}", ConsoleColor.Green);
                    ViewUtils.PaintWriteLine($"\nSalário Final: R$ {finalSalary:F2}", ConsoleColor.Green);
                }

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
            ViewUtils.PaintWriteLine($" Calculadora - Salário | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static decimal SalaryIncrease(decimal initialSalary)
        {
            return initialSalary * 1.15m;
        }
        static decimal SalaryDecrease(decimal increasedSalary)
        {
            return increasedSalary * 0.92m;
        }
    }
}

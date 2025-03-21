using Microsoft.VisualBasic;
using System.Security.Principal;
using Utils;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal baseSalary, totalSales, commissionPercentage, totalSalary;
            bool onMenu, seeCalc;
            do
            {
                Header();
                baseSalary = Validators.DecimalVerify("Digite o salário base do vendedor: R$ ");
                totalSales = Validators.DecimalVerify("Digite o total de vendas do vendedor: R$ ");
                commissionPercentage = Validators.DecimalVerify("Qual a porcentagem de comissão do vendedor sobre as vendas? ");

                totalSalary = Result(baseSalary, totalSales, commissionPercentage);

                seeCalc = Validators.YesOrNo("\nValores anotados! Quer acompanhar as estapas do cálculo? (S/N) ");
                if (seeCalc == true)
                    MathCalc(baseSalary, totalSales, commissionPercentage, totalSalary);
                else
                    ViewUtils.PaintWriteLine($"\nO salário total do vendedor é de: R$ {totalSalary:F2}", ConsoleColor.Green);

                onMenu = Validators.YesOrNo("\nDeseja fazer um novo cálculo? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($"  Calculadora - Salário Total do Vendedor | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static decimal Result(decimal baseSalary, decimal totalSales, decimal commissionPercentage)
        {
            return baseSalary + ((commissionPercentage / 100) * totalSales);
        }
        static void MathCalc(decimal baseSalary, decimal totalSales, decimal commissionPercentage, decimal totalSalary)
        {
            Header();
            ViewUtils.PaintWriteLine($"\nPara calcular o salário total do vendedor, com os seguintes valores:");
            ViewUtils.PaintWriteLine($"Salário Base: R$ {baseSalary:F2}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Vendas Totais: R$ {totalSales:F2}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Comissão: {commissionPercentage}%", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"\nVamos usar a seguinte fórmula:");
            ViewUtils.PaintWriteLine($"SalárioTotal = SalarioBase + (Comissão * VendasTotais)", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"SalárioTotal = {baseSalary:F2} + ({(commissionPercentage / 100):F2} * {totalSales:F2})", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"SalárioTotal = {baseSalary:F2} + {((commissionPercentage / 100) * totalSales):F2}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"SalárioTotal = {(baseSalary + ((commissionPercentage / 100) * totalSales)):F2}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"\nSendo assim, o salário total do vendedor é de: R$ {totalSalary:F2}", ConsoleColor.Green);
        }
    }
}

using System.Reflection;
using Utils;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal kmInicial, kmFinal, combustivel, consumo;
            bool onMenu = true;
            bool seeCalc;
            do
            {
                Header();
                kmInicial = Validators.DecimalVerify("\nDigite a quilometragem inicial: ");
                kmFinal = Validators.DecimalVerify("\nDigite a quilometragem final: ");
                combustivel = Validators.DecimalVerify("\nDigite o consumo de combustível: ");

                if (kmFinal <= kmInicial)
                {
                    ViewUtils.PaintWriteLine("\nA quilometragem final precisa ser maior que a inicial.\n", ConsoleColor.Red);
                    ViewUtils.PressEnter("TENTAR-NOVAMENTE");
                    continue;
                }
                consumo = Result(combustivel, kmInicial, kmFinal);

                seeCalc = Validators.YesOrNo("\nValores anotados, gostaria de ver o cálculo? (S/N) ");
                if (seeCalc == true)
                    MathCalc(combustivel, kmInicial, kmFinal, consumo);
                else
                    ViewUtils.PaintWriteLine($"\nO consumo por km é de: {consumo:F3} litros/km.", ConsoleColor.Green);

                onMenu = Validators.YesOrNo("\nDeseja fazer um novo cálculo? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Calculadora de Consumo de Combustível por km || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static decimal Result(decimal combustivel, decimal kmInicial, decimal kmFinal)
        {
            return combustivel / (kmFinal - kmInicial);
        }
        static void MathCalc(decimal combustivel, decimal kmInicial, decimal kmFinal, decimal consumo)
        {
            Header();
            ViewUtils.PaintWriteLine("Para calcular o consumo de combustível por Km com as seguintes medidas:");
            ViewUtils.PaintWriteLine($"Km Inicial: {kmInicial}km", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Km Final:  {kmFinal}km", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Distância percorrida: {kmFinal - kmInicial}km", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Combustível consumido: {combustivel}L", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"\nVamos usar a seguinte fórmula:");
            ViewUtils.PaintWriteLine($"Consumo = {combustivel} / ({kmFinal} - {kmInicial})", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Consumo = {combustivel} / {kmFinal - kmInicial}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Consumo = {(combustivel / (kmFinal - kmInicial)):F3}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"\nSendo assim, o consumo por km é de: {consumo:F3} litros/km.", ConsoleColor.Green);
        }
    }
}

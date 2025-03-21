using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Utils;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal lenght, width, height;
            bool onMenu;
            bool seeCalc;
            do
            {
                Header();
                lenght = Validators.DecimalVerify("Digite o comprimento em cm: ");
                width = Validators.DecimalVerify("Digite a largura em cm: ");
                height = Validators.DecimalVerify("Digite a altura em cm: ");
                decimal volume = Result(lenght, width, height);

                seeCalc = Validators.YesOrNo("\nValores anotados, gostaria de ver o cálculo? (S/N) ");
                if (seeCalc == true)
                    MathCalc(lenght, width, height, volume);
                else
                    ViewUtils.PaintWriteLine($"\nO volume dessa caixa retangular é: {volume:F3}m³", ConsoleColor.Green);

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
            ViewUtils.PaintWriteLine($" Calculadora De Volume - Caixa Retangular || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==\n", ConsoleColor.Cyan);
        }
        static decimal Result(decimal lenght, decimal width, decimal height)
        {
            return lenght * width * height;
        }
        static void MathCalc(decimal lenght, decimal width, decimal height, decimal volume)
        {
            Header();
            ViewUtils.PaintWriteLine("Para calcular o volume da caixa retangular com as seguintes medidas:");
            ViewUtils.PaintWriteLine($"Comprimento: {lenght}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Largura: {width}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Altura: {height}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"\nVamos usar a seguinte fórmula:");
            ViewUtils.PaintWriteLine($"Volume = {lenght} * {width} * {height}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Volume = {lenght * width} * {height}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Volume = {lenght * width * height}", ConsoleColor.Yellow);

            ViewUtils.PaintWriteLine($"\nSendo assim, o volume dessa caixa retangular é: {volume:F3}m³", ConsoleColor.Green);
        }
    }
}

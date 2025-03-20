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
            bool onMenu = true;
            do
            {
                Header();
                lenght = Validators.DecimalVerify("Digite o comprimento em cm: ");
                width = Validators.DecimalVerify("Digite a largura em cm: ");
                height = Validators.DecimalVerify("Digite a altura em cm: ");
                decimal volume = Result(lenght, width, height);

                ViewUtils.PaintWrite("\nValores anotados, gostaria de ver o cálculo? (S/N) ", ConsoleColor.Yellow);
                string option = Validators.StringVerify("Isso não é uma opção..", 1);

                switch (option.ToUpper())
                {
                    case "S":
                        MathCalc(lenght, width, height, volume);
                        break;
                    case "N":
                        ViewUtils.PaintWriteLine($"\nO volume dessa caixa retangular é: {volume.ToString("F3")}m³", ConsoleColor.Green);
                        break;
                }

                ViewUtils.PaintWrite("\nPressione [Enter] para fazer um novo cálculo.", ConsoleColor.DarkYellow);
                Console.ReadKey();
            } while (onMenu);
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

            ViewUtils.PaintWriteLine($"\nSendo assim, o Volume dessa caixa retangular é: {volume.ToString("F3")}m³", ConsoleColor.Green);
        }
    }
}

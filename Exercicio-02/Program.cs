using System.Globalization;
using Utils;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume, radius, height;
            double PI = Math.PI;
            bool onMenu;
            bool seeCalc;
            do
            {
                Header();
                radius = Validators.DoubleVerify("Digite o valor do raio da base do cilindro: ");
                height = Validators.DoubleVerify("Digite o valor da altura do cilindro: ");
                volume = Result(PI, radius, height);

                seeCalc = Validators.YesOrNo("\nValores anotados, gostaria de ver o cálculo? (S/N) ");
                if (seeCalc == true)
                    MathCalc(PI, volume, radius, height);
                else
                    ViewUtils.PaintWriteLine($"\nO volume desse cilindro é: {volume:F3}cm³", ConsoleColor.Green);

                onMenu = Validators.YesOrNo("\nDeseja fazer um novo cálculo? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Calculadora De Volume - Cilindro || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==\n", ConsoleColor.Cyan);
        }
        static double Result(double PI, double radius, double height)
        {
            return PI * Math.Pow(radius, 2) * height;
        }
        static void MathCalc(double PI, double volume, double radius, double height)
        {
            Header();
            ViewUtils.PaintWriteLine("Para calcular o volume do cilindro com as seguintes medidas:");
            ViewUtils.PaintWriteLine($"Raio: {radius}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Altura: {height}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"PI: {PI:F4}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"\nVamos usar a seguinte fórmula:");
            ViewUtils.PaintWriteLine($"Volume = {PI:F4} * {radius}² * {height}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Volume = {PI:F4} * {Math.Pow(radius, 2)} * {height}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Volume = {(PI * Math.Pow(radius, 2) * height):F3}", ConsoleColor.Yellow);

            ViewUtils.PaintWriteLine($"\nSendo assim, o volume desse cilindro é: {volume:F3}cm³", ConsoleColor.Green);
        }
    }
}

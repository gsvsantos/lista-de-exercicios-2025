using Utils;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //f = (9/5 * c) + 32;
            decimal fahrenheit, celsius;
            bool onMenu, seeCalc;
            do
            {
                Header();
                celsius = Validators.DecimalVerify("\nDigite a temperatura atual em celsius (°C): ", decimal.MinValue);
                fahrenheit = Result(celsius);
                seeCalc = Validators.YesOrNo("\nDeseja acompanhar as estapas do cálculo? (S/N) ");

                if (seeCalc == true)
                    MathCalc(celsius, fahrenheit);
                else
                    ViewUtils.PaintWriteLine($"\n{celsius}°C convertido em Fahreinheit (°F) é: {fahrenheit}°F", ConsoleColor.Green);

                onMenu = Validators.YesOrNo("\nDeseja fazer um novo cálculo? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Conversor de Temperatura - Celsius (°C) para Fahrenheit (°F) || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static decimal Result(decimal celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        static void MathCalc(decimal celsius, decimal fahrenheit)
        {
            Header();
            ViewUtils.PaintWriteLine($"\nPara converter a temperatura {celsius}°C para Fahrenheit (°F), vamos usar a seguinte fórmula:");
            ViewUtils.PaintWriteLine($"Fahrenheit = (Celsius * 9/5) + 32", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Fahrenheit = ({celsius} * 9/5) + 32", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Fahrenheit = {celsius * 9/5} + 32", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"Fahrenheit = {(celsius * 9 / 5) + 32}", ConsoleColor.Yellow);
            ViewUtils.PaintWriteLine($"\nSendo assim, {celsius}°C convertido em Fahreinheit (°F) é: {fahrenheit}°F", ConsoleColor.Green);
        }
    }
}

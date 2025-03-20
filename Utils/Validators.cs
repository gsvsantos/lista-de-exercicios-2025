using System.Globalization;

namespace Utils
{
    public class Validators
    {
        public static string StringVerify(string lenghtError, int minLenght)
        {
            do
            {
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                    ViewUtils.PaintWriteLine($"'{input}' não me parece correto...");
                    continue;
                }
                if (!input.All(char.IsLetter))
                {
                    ViewUtils.PaintWriteLine($"Tem algo de errado com essa palavra... ({input})");
                    continue;
                }
                if (input.Length < minLenght)
                {
                    ViewUtils.PaintWriteLine(lenghtError);
                    continue;
                }
                return input;
            } while (true);
        }
        public static decimal DecimalVerify(string prompt, decimal minValue = 0, decimal maxValue = decimal.MaxValue)
        {
            do
            {
                ViewUtils.PaintWrite(prompt);
                string input = Console.ReadLine()!.Replace('.', ',');
                if (string.IsNullOrEmpty(input))
                {
                    ViewUtils.PaintWriteLine($"Um número não pode ser vazio.", ConsoleColor.Red);
                    continue;
                }
                input = input.Trim();
                if (!decimal.TryParse(input, out decimal value))
                {
                    ViewUtils.PaintWriteLine($"'{input}' não é um número valido..", ConsoleColor.Red);
                    continue;
                }
                if (value <= minValue || value > maxValue)
                {
                    ViewUtils.PaintWriteLine($"O valor deve estar entre {minValue} e {maxValue.ToString("E2")}.", ConsoleColor.Red);
                    continue;
                }
                return value;
            } while (true);
        }
        public static double DoubleVerify(double minValue = 1, double maxValue = double.MaxValue)
        {
            do
            {
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                    ViewUtils.PaintWriteLine($"{input} não é um número...", ConsoleColor.Red);
                    continue;
                }
                if (!double.TryParse(input, CultureInfo.InvariantCulture, out double value))
                {
                    ViewUtils.PaintWriteLine($"O número digitado não é valido..", ConsoleColor.Red);
                    continue;
                }
                if (value < minValue || value > maxValue)
                {
                    ViewUtils.PaintWriteLine($"O valor deve estar entre {minValue} e {maxValue}.", ConsoleColor.Red);
                    continue;
                }
                return value;
            } while (true);
        }
        public static int IntVerify(int minValue = 1, int maxValue = int.MaxValue)
        {
            do
            {
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                    ViewUtils.PaintWriteLine($"{input} não é um número...", ConsoleColor.Red);
                    continue;
                }
                input = input.Trim();
                if (input.Contains(' ') || input.Contains('.') || input.Contains(','))
                {
                    ViewUtils.PaintWriteLine("O valor não pode conter espaço ' ', ponto (.), ou vírgula (,)!", ConsoleColor.Red);
                    continue;
                }
                if (!int.TryParse(input, out int value))
                {
                    ViewUtils.PaintWriteLine("O valor digitado não é um número válido.", ConsoleColor.Red);
                    continue;
                }
                if (value < minValue || value > maxValue)
                {
                    ViewUtils.PaintWriteLine($"O valor deve estar entre {minValue} e {maxValue}.", ConsoleColor.Red);
                    continue;
                }
                return value;
            } while (true);
        }
    }
}

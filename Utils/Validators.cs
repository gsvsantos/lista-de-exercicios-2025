using System.Globalization;

namespace Utils
{
    public class Validators
    {
        public static string LetterVerify()
        {
            do
            {
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                    ViewUtils.PaintWriteLine($"Precisa conter uma letra...", ConsoleColor.Red);
                    continue;
                }
                if (!input.All(char.IsLetter))
                {
                    ViewUtils.PaintWriteLine("Por favor, digite uma letra!", ConsoleColor.Red);
                    continue;
                }
                if (input.Length > 1)
                {
                    ViewUtils.PaintWriteLine("Precisa ser apenas uma letra...", ConsoleColor.Red);
                    continue;
                }
                return input = input.ToUpper();
            } while (true);
        }
        public static string StringVerify(string lenghtError, int minLenght)
        {
            do
            {
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                    ViewUtils.PaintWriteLine($"'{input}' não me parece correto...", ConsoleColor.Red);
                    continue;
                }
                if (!input.All(char.IsLetter))
                {
                    ViewUtils.PaintWriteLine($"Tem algo de errado com essa palavra... ({input})", ConsoleColor.Red);
                    continue;
                }
                if (input.Length < minLenght)
                {
                    ViewUtils.PaintWriteLine(lenghtError, ConsoleColor.Red);
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
                    ViewUtils.PaintWriteLine($"O valor deve estar entre 1 e {maxValue:E2}.", ConsoleColor.Red);
                    continue;
                }
                return value;
            } while (true);
        }
        public static double DoubleVerify(string prompt, double minValue = 0, double maxValue = double.MaxValue)
        {
            do
            {
                ViewUtils.PaintWrite(prompt);
                string input = Console.ReadLine()!.Replace('.', ',');
                if (string.IsNullOrEmpty(input))
                {
                    ViewUtils.PaintWriteLine($"Um número não pode ser vazio...", ConsoleColor.Red);
                    continue;
                }
                if (!double.TryParse(input, CultureInfo.InvariantCulture, out double value))
                {
                    ViewUtils.PaintWriteLine($"O número digitado não é valido..", ConsoleColor.Red);
                    continue;
                }
                if (value <= minValue || value > maxValue)
                {
                    ViewUtils.PaintWriteLine($"O valor deve estar entre 1 e {maxValue:E2}.", ConsoleColor.Red);
                    continue;
                }
                return value;
            } while (true);
        }
        public static int IntVerify(string prompt, int minValue = 0, int maxValue = int.MaxValue)
        {
            do
            {
                ViewUtils.PaintWrite(prompt);
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
                if (value <= minValue || value > maxValue)
                {
                    ViewUtils.PaintWriteLine($"O valor deve estar entre 1 e {maxValue:E2}.", ConsoleColor.Red);
                    continue;
                }
                return value;
            } while (true);
        }
        public static bool YesOrNo(string prompt)
        {
            do
            {
                ViewUtils.PaintWrite(prompt, ConsoleColor.Yellow);
                string option = Validators.LetterVerify();
                option = option.ToUpper();
                if (option != "S" && option != "N")
                {
                    ViewUtils.PaintWriteLine("Opção inválida!", ConsoleColor.Red);
                    continue;
                }

                if (option == "S")
                    return true;
                else
                    return false;
            } while (true);
        }
}

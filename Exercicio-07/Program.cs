using Utils;

namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal firstTestNote, secondTestNote, firstTestWeight, secondTestWeight, weightedMean;
            bool onMenu = true;
            do
            {
                Header();
                firstTestNote = Validators.DecimalVerify("Qual a primeira nota? ");
                firstTestWeight = Validators.DecimalVerify("Qual o peso dela? ");
                secondTestNote = Validators.DecimalVerify("Qual a segunda nota? ");
                secondTestWeight = Validators.DecimalVerify("Qual o peso dela? ");

                weightedMean = Result(firstTestNote, secondTestNote, firstTestWeight, secondTestWeight);
                if (weightedMean == 0)
                {
                    ViewUtils.PressEnter("TENTAR-NOVAMENTE");
                    continue;
                }

                ViewUtils.PaintWriteLine($"A média ponderada das provas desse aluno é: {weightedMean:F1}", ConsoleColor.Green);

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
            ViewUtils.PaintWriteLine($" Calculadora - Média Ponderada | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static decimal Result(decimal firstTestNote, decimal secondTestNote, decimal firstTestWeight, decimal secondTestWeight)
        {
            if(firstTestWeight == 0 && secondTestWeight == 0)
            {
                ViewUtils.PaintWriteLine("\nOs pesos das duas provas não podem ser 0!\n", ConsoleColor.Red);
                return 0;
            }
            if(firstTestNote == 0 && secondTestNote == 0)
            {
                ViewUtils.PaintWriteLine("\nEsse aluno não foi nada bem... Média de: 0\n", ConsoleColor.Red);
                return 0;
            }
            return (firstTestNote * firstTestWeight + secondTestNote * secondTestWeight) / (firstTestWeight + secondTestWeight);
        }
    }
}

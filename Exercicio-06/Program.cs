using Microsoft.VisualBasic;
using System.Diagnostics;
using Utils;

namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int notesQuantity;
            decimal harmonicMean;
            bool onMenu = true;
            do
            {
                decimal sum = 0;
                bool negativeNote = false;
                Header();
                notesQuantity = Validators.IntVerify("Digite a quantidade de notas que o aluno tem: ");
                decimal[] notes = new decimal[notesQuantity];

                harmonicMean = HarmonicMeanCalc(notes, sum, notesQuantity,ref negativeNote);
                if (negativeNote == true)
                {
                    ViewUtils.PressEnter("TENTAR-NOVAMENTE");
                    continue;
                }
                ViewUtils.PaintWriteLine($"\nCom essas notas, a média harmônica do aluno é: {harmonicMean:F2}", ConsoleColor.Green);

                onMenu = Validators.YesOrNo("\nDeseja fazer outro cálculo? (S/N)");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($" Calculadora - Média Harmônica | {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static decimal HarmonicMeanCalc(decimal[] notes, decimal sum, int notesQuantity,ref bool negativeNote)
        {
            for (int i = 0; i < notesQuantity; i++)
            {
                notes[i] = Validators.DecimalVerify($"Digite a nota #{i + 1}: ");
                if (notes[i] == 0)
                {
                    ViewUtils.PaintWriteLine("\nPor favor, evite acrescentar notas zeradas a lista!\n", ConsoleColor.Red);
                    negativeNote = true;
                    return 0;
                }
                else
                    sum += 1 / notes[i];
            }
            return notesQuantity / sum;
        }
    }
}

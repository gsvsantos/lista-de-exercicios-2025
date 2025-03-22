using Utils;

namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height, imc;
            bool onMenu;
            do
            {
                Header();
                weight = Validators.DoubleVerify("Digite seu peso atual: ");
                height = Validators.DoubleVerify("Digite sua altura: ");
                imc = BMICalc(weight, height);

                ViewUtils.PaintWriteLine($"\nSeu IMC é de: {imc:F2}", ConsoleColor.Green);
                BMICheck(imc);

                onMenu = Validators.YesOrNo("\nDeseja fazer outro cálculo? (S/N) ");
            } while (onMenu);
            Console.Clear();
            ViewUtils.PaintWriteLine("Adeus (T_T)/", ConsoleColor.Magenta);
        }
        static void Header()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
            ViewUtils.PaintWriteLine($"  Calculadora - Índice de Massa Corporal || {date:dd/MM/yyyy HH:mm}");
            ViewUtils.PaintWriteLine("==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==~~==", ConsoleColor.Cyan);
        }
        static double BMICalc(double weight, double height)
        {
            return weight / Math.Pow(height / 100, 2);
        }
        static void BMICheck(double imc)
        {
            if (imc < 18.5)
                ViewUtils.PaintWriteLine("Você está abaixo do peso ideal!", ConsoleColor.Red);
            if (imc >= 18.5 && imc <= 24.9)
                ViewUtils.PaintWriteLine("Você está com o peso ideal.", ConsoleColor.Green);
            if (imc >= 25 && imc <= 29.9)
                ViewUtils.PaintWriteLine("Você está acima do peso ideal...", ConsoleColor.Red);
            if (imc >= 30 && imc <= 34.9)
                ViewUtils.PaintWriteLine("Você está com nível de obesidade de grau 1!", ConsoleColor.DarkBlue);
            if (imc >= 35 && imc <= 39.9)
                ViewUtils.PaintWriteLine("Você está com nível de obesidade de grau 2!", ConsoleColor.DarkBlue);
            if (imc >= 40)
                ViewUtils.PaintWriteLine("Você está com nível de obesidade de grau 3!", ConsoleColor.DarkBlue);
        }
    }
}

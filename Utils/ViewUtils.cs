namespace Utils
{
    public class ViewUtils
    {
        public static void PaintWriteLine(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void PaintWrite(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
        public static void PressEnter(string type)
        {
            switch (type)
            {
                case "TENTAR-NOVAMENTE":
                    PaintWrite("Pressione [Enter] para tentar novamente.", ConsoleColor.Yellow);
                    Console.ReadKey();
                    break;
                case "VOLTAR-MENU":
                    PaintWrite("Pressione [Enter] para voltar ao menu principal.", ConsoleColor.Yellow);
                    Console.ReadKey();
                    break;
                case "VER-RESULTADO":
                    PaintWrite("Pressione [Enter] para ver o resultado.", ConsoleColor.Yellow);
                    Console.ReadKey();
                    break;
            }
        }
    }
}

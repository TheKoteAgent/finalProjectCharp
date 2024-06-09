using MainFunc;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spravi spravi = new Spravi();
            int cho;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;           
                Console.WriteLine("\tWelcome!");
                Console.ResetColor();
                Console.WriteLine("------------------------|");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1 - show spravi         |");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("2 - add sprava          |");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("3 - delete sprava       |");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("4 - searche by name     |");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("5 - save sprava to file |");
                Console.ResetColor();
                Console.WriteLine("------------------------|");
                
                string choi = Console.ReadLine();
                if (int.TryParse(choi, out cho))
                {
                    switch (cho)
                    {
                        case 1:
                            spravi.Show();
                            break;
                        case 2:
                            spravi.addSprava();
                            break;
                        case 3:
                            spravi.DeleteSprava();
                            break;
                        case 4:
                            spravi.SearchByName();
                            break;
                        case 5:
                            spravi.SaveToFile();
                            break;
                        default:
                            Console.WriteLine("incorect choice");
                            break;
                            
                    }
                }
            }
        }
    }
}

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
                Console.WriteLine("Welcome!\n1 - show sprav\n2 - add sprava\n3 - delete sprava\n4 - searche by name\n5 - save sprava to file");
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

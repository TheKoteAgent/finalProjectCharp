using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFunc
{
    class Sprava
    {
        public string Name;
        public DateTime Date;

        public Sprava(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Name} - {Date.ToShortDateString()}"; 
        }
    }


    class Spravi
    {
        private List<Sprava> spraviList = new List<Sprava>();

        public void addSprava()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter data (dd/MM/yyyy):");
            string data = Console.ReadLine();
            DateTime date;

            if (!string.IsNullOrWhiteSpace(name) && DateTime.TryParseExact(data, "dd/MM/yyyy", null, DateTimeStyles.None, out date))
            {
                Sprava newSprava = new Sprava(name, date);
                spraviList.Add(newSprava);
                Console.WriteLine("Sprava added");             

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("enter 1 to back to menu\n->");
            int a;
            string aa = Console.ReadLine();
            if (int.TryParse(aa, out a))
            {
                if (a == 1)
                {
                    Console.Clear();
                }
            }
            Console.ResetColor();
            Console.ResetColor();
        }

        public void DeleteSprava()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            var sprava = spraviList.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (sprava != null)
            {
                spraviList.Remove(sprava);
                Console.WriteLine("deleted");
            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("enter 1 to back to menu\n->");
            int a;
            string aa = Console.ReadLine();
            if (int.TryParse(aa, out a))
            {
                if (a == 1)
                {
                    Console.Clear();
                }
            }
            Console.ResetColor();
            Console.ResetColor();
        }
        public void SearchByName()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            var res = spraviList.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (res.Count > 0)
            {
                Console.WriteLine("results:");
                foreach (var sprava in res)
                {
                    Console.WriteLine(sprava);
                }
            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("enter 1 to back to menu\n->");
            int a;
            string aa = Console.ReadLine();
            if (int.TryParse(aa, out a))
            {
                if (a == 1)
                {
                    Console.Clear();
                }
            }
            Console.ResetColor();
            Console.ResetColor();
        }

        public void SaveToFile()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter path:");
            string filePath = Console.ReadLine();

            using (StreamWriter wr = new StreamWriter(filePath))
            {
                foreach (var sprava in spraviList)
                {
                    wr.WriteLine($"{sprava.Name},{sprava.Date.ToString("dd/MM/yyyy")}");
                }
            }
            Console.WriteLine("Spravi saved");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter 1 to back to menu\n->");

            int a;
            string aa = Console.ReadLine();
            if (int.TryParse(aa, out a))
            {
                if (a == 1)
                {
                    Console.Clear();
                }
            }

            Console.ResetColor();
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Spravi:");
            for (int i = 0; i < spraviList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {spraviList[i]}");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("enter 1 to back to menu\n->");
            int a;
            string aa = Console.ReadLine();
            if (int.TryParse(aa, out a))
            {
                if (a == 1)
                {
                    Console.Clear();
                }
            }
            Console.ResetColor();
            Console.ResetColor();
        }
    }
}

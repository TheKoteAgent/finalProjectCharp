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
        }

        public void DeleteSprava()
        {
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
        }
        public void SearchByName()
        {
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
        }

        public void SaveToFile()
        {
            string filePath = "spravi.txt";
            using (StreamWriter wr = new StreamWriter(filePath))
            {
                foreach (var sprava in spraviList)
                {
                    wr.WriteLine($"{sprava.Name},{sprava.Date.ToString("dd/MM/yyyy")}");
                }
            }
            Console.WriteLine("Spravi saved");
        }
        public void Show()
        {
            Console.WriteLine("Spravi:");
            for (int i = 0; i < spraviList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {spraviList[i]}");
            }
            
        }
    }
}

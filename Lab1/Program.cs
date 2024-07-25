using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> comps = new List<Computer>()
            {
                new Computer(){Code = 1, Brands = "4Aces Hold'em",CPU="Ryzen 5 3600",  CPUFrequency=3600, RAM=16, MemoryHardDisk=512, MemoryVideoCard=4, Price=65999, Amount=3},
                new Computer(){Code = 2, Brands = "Thunderobot Warrior Super",CPU="Core i5-13400",  CPUFrequency=2500, RAM=16, MemoryHardDisk=1512, MemoryVideoCard=8, Price=143499, Amount=5},
                new Computer(){Code = 3, Brands = "Msi MPG Trident AS 13NUC5-634RU",CPU="Core i5-13400F",  CPUFrequency=2500, RAM=16, MemoryHardDisk=1512, MemoryVideoCard=8, Price=143499, Amount=8},
                new Computer(){Code = 4, Brands = "Thunderobot Warrior Turbo",CPU="Core i5-13400",  CPUFrequency=2500, RAM=32, MemoryHardDisk=3000, MemoryVideoCard=12, Price=136000, Amount=8},
                new Computer(){Code = 5, Brands = "Lyambda Bumblebee",CPU="Core i7-12700F",  CPUFrequency=2100, RAM=32, MemoryHardDisk=2000, MemoryVideoCard=8, Price=203999, Amount=2},
                new Computer(){Code = 6, Brands = "Thunderobot Warrior Super RL1",CPU="Core i5-13400",  CPUFrequency=2500, RAM=16, MemoryHardDisk=1000, MemoryVideoCard=8, Price=129999, Amount=10},
                new Computer(){Code = 7, Brands = "Raskat Strike 320",CPU="Core i3-12100F",  CPUFrequency=3300, RAM=16, MemoryHardDisk=512, MemoryVideoCard=4, Price=63999, Amount=15},
                new Computer(){Code = 8, Brands = "Robotcomp Зевс 2.0 Pink V2",CPU="Core i9-12900KF",  CPUFrequency=2600, RAM=32, MemoryHardDisk=2000, MemoryVideoCard=12, Price=255190, Amount=1},
                new Computer(){Code = 9, Brands = "RIVAL III",CPU="AMD Ryzen 7 7700X",  CPUFrequency=4500, RAM=32, MemoryHardDisk=2000, MemoryVideoCard=16, Price=288450, Amount=4},
                new Computer(){Code = 10, Brands = "FURYPC 110653",CPU="Intel Core i5-11400F",  CPUFrequency=2600, RAM=16, MemoryHardDisk=960, MemoryVideoCard=2, Price=47950, Amount=15},
            };

            Console.WriteLine("Введите процессор");
            string cpu = Console.ReadLine();
            List<Computer> computers1 = comps.Where(x => x.CPU == cpu).ToList();
            Print(computers1);

            Console.WriteLine("Введите частоту процессора");
            int cpuFrequency = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = comps.Where(x => x.CPUFrequency >= cpuFrequency).ToList();
            Print(computers2);

            List<Computer> computers3 = comps.OrderBy(x => x.Price).ToList();
            Print(computers3);

            IEnumerable<IGrouping<string, Computer>> computers4 = comps.GroupBy(x => x.CPU);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer c in gr)
                {
                    Console.WriteLine($"{c.Code} {c.Brands} {c.CPUFrequency} {c.RAM} {c.MemoryHardDisk} {c.MemoryVideoCard} {c.Price} {c.Amount}");
                }
            }


            Computer computersMax = comps.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"Самый дорогой:{computersMax.Code} {computersMax.Brands} {computersMax.CPU} " +
                $"{computersMax.CPUFrequency} {computersMax.RAM} {computersMax.MemoryHardDisk} " +
                $"{computersMax.MemoryVideoCard} {computersMax.Price} {computersMax.Amount}");
            Computer computersMin = comps.OrderByDescending(x => x.Price).LastOrDefault();
            Console.WriteLine($"Самый бюджетный:{computersMin.Code} {computersMin.Brands} {computersMin.CPU} " +
                $"{computersMin.CPUFrequency} {computersMin.RAM} {computersMin.MemoryHardDisk} " +
                $"{computersMin.MemoryVideoCard} {computersMin.Price} {computersMin.Amount}");

            Console.WriteLine(comps.Any(x=>x.Amount > 30));
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Code} {c.Brands} {c.CPU} {c.CPUFrequency} {c.RAM} {c.MemoryHardDisk} {c.MemoryVideoCard} {c.Price} {c.Amount}");
            }
            Console.WriteLine();
        }
    }
}

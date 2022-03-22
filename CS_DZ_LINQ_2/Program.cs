using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_LINQ_2
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Prisioner> prisioners = new List<Prisioner> { new Prisioner("Гусь Хрустальный", "Антиправительственное"), new Prisioner("Вомбат Картофаныч", "Ложные показания"),
            new Prisioner("Ирина Алегровна", "Антиправительственное"), new Prisioner("Алексей Индюшкин", "Убийство")};

            foreach (var prisioner in prisioners)
            {
                Console.WriteLine(prisioner.Name);
            }

            var prisionersInPrison = prisioners.Where(prisioner => !prisioner.Crime.Contains("Антиправительственное"));

            Console.SetCursorPosition(0, 5);

            foreach (var prisioner in prisionersInPrison)
            {
                Console.WriteLine(prisioner.Name);
            }
        }
    }

    class Prisioner
    {
        public string Name { get; private set; }

        public string Crime { get; private set; }

        public Prisioner(string name, string crime)
        {
            Name = name;
            Crime = crime;
        }
    }
}

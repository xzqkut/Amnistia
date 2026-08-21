using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amnistia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arstozka arstozka = new Arstozka();
            arstozka.GetAmnistia();
            arstozka.ShowPrisoners();
            Console.ReadLine();
        }
    }

    class Prisoner
    {
        public string Name { get; private set; }
        public string Crime { get; private set; }

        public Prisoner(string name, string crime)
        {
            Name = name;
            Crime = crime;
        }

        public void ShowPrisonerInfo()
        {
            Console.WriteLine($"Name: {Name}, Crime: {Crime}");
        }
    }

    class Arstozka
    {
        private List<Prisoner> _prisoners = new List<Prisoner>();
        private List<Prisoner> _amnistiaPrisoners = new List<Prisoner>();

        public Arstozka()
        {
            CreatePrisoner();
        }

        public void CreatePrisoner()
        {
            _prisoners.Add(new Prisoner("Джон", "Антиправительственное"));
            _prisoners.Add(new Prisoner("Мария", "Кража"));
            _prisoners.Add(new Prisoner("Алексей", "Мошенничество"));
            _prisoners.Add(new Prisoner("Екатерина", "Нарушение закона"));
            _prisoners.Add(new Prisoner("Иван", "Антиправительственное"));
            _prisoners.Add(new Prisoner("Сергей", "Антиправительственное"));
        }

        public void GetAmnistia()
        {
           _amnistiaPrisoners=_prisoners.Where(x=>x.Crime!="Антиправительственное").ToList();
        }

        public void ShowPrisoners()
        {
            Console.WriteLine("Список заключенных:");

            foreach (var prisoner in _prisoners)
            {
                prisoner.ShowPrisonerInfo();
            }

            Console.WriteLine("Список заключенных, освобожденных по амнистии:");
            foreach (var prisoner in _amnistiaPrisoners)
            {
                prisoner.ShowPrisonerInfo();
            }

        }
    }
}

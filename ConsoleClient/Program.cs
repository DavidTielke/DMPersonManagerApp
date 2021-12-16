using System;
using System.Linq;
using DavidTielke.DMPMA.Logic.PersonManagement;

namespace DavidTielke.DMPMA.UI.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new PersonManager();

            var adults = manager.GetAllAdults().ToList();
            var children = manager.GetAllChildren().ToList();

            Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
            adults.ForEach(a => Console.WriteLine(a.Name));

            Console.WriteLine($"### Kinder ({children.Count}) ###");
            children.ForEach(c => Console.WriteLine(c.Name));
        }
    }
}

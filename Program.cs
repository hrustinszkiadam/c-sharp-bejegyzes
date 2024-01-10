using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bejegyzes;

internal class Program
{
    static void Main(string[] args)
    {
        List<Bejegyzes> bejegyzesek = [
            new Bejegyzes("Első bejegyzés", "Ez az első bejegyzés szövege"),
            new Bejegyzes("Második bejegyzés", "Ez a második bejegyzés szövege")
        ];

        int ujDarab = 0;
        Console.Write("Hány új bejegyzést szeretnél létrehozni? ");
        ujDarab = int.Parse(Console.ReadLine() ?? "1");
        for (int i = 0; i < ujDarab; i++)
        {
            string szerzo = "";
            string tartalom = "";
            while (szerzo == "")
            {
                Console.Write("Szerző: ");
                szerzo = Console.ReadLine() ?? "";
            }
            while (tartalom == "")
            {
                Console.Write("Tartalom: ");
                tartalom = Console.ReadLine() ?? "";
            }
            bejegyzesek.Add(new Bejegyzes(szerzo, tartalom));
        }

        Bejegyzes randomBejegyzes = bejegyzesek[new Random().Next(0, bejegyzesek.Count)];
        for(int i = 0; i < bejegyzesek.Count*20; i++)
        {
            randomBejegyzes.Like();
        }

        Console.WriteLine("Módosítsd a második bejegyzést:");
        Bejegyzes masodik = bejegyzesek[1];
        string ujSzerzo = "";
        string ujTartalom = "";
        while (ujSzerzo == "")
        {
            Console.Write("Szerző: ");
            ujSzerzo = Console.ReadLine() ?? "";
        }
        while (ujTartalom == "")
        {
            Console.Write("Tartalom: ");
            ujTartalom = Console.ReadLine() ?? "";
        }

        Console.WriteLine("Bejegyzések:");
        foreach (Bejegyzes bejegyzes in bejegyzesek)
        {
            Console.WriteLine(bejegyzes);
            Console.WriteLine();
        }

        Bejegyzes legnepszerubb = bejegyzesek.OrderByDescending(x => x.Likeok).First();
        Console.WriteLine($"A legnépszerűbb bejegyzés:\n{legnepszerubb}");

        Console.ReadKey();
    }
}

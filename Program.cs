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
        Console.ReadKey();
    }
}

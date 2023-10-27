using System.Text;

namespace Szoftverek
{
    internal class Program
    {
        static List<Szoftver> szoftverek = new();
        static void Main()
        {
            using var sr = new StreamReader(path: @"..\..\..\src\szoftverek.txt", encoding: Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) szoftverek.Add(new Szoftver(sr.ReadLine()));

            Console.WriteLine("6. feladat");
            szoftverek.ForEach(sz => Console.WriteLine(sz));

            Console.WriteLine("7. feladat");
            var f7 = szoftverek.Where(s => s.Kategoria == "antivírus" && s.Ertekeles > 8.5);
            Console.WriteLine($"{f7.Count()}db van belőle.");

            var maxErtekeles = szoftverek.Max(s => s.Ertekeles) - .1;
            var f8 = szoftverek.Where(s => s.Ertekeles < maxErtekeles);


        }
    }
}
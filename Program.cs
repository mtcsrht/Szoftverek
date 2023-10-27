using System.Text;

namespace Szoftverek
{
    internal class Program
    {
        static List<Szoftver> szoftverek = new();
        static void Main()
        {
            #region Beolvasas
            using var sr = new StreamReader(path: @"..\..\..\src\szoftverek.txt", encoding: Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) szoftverek.Add(new Szoftver(sr.ReadLine()));
            #endregion

            #region 6. feladat
            Console.WriteLine("6. feladat");
            szoftverek.ForEach(sz => Console.WriteLine(sz));
            #endregion

            #region 7. feladat
            Console.WriteLine("7. feladat");
            var f7 = szoftverek.Where(s => s.Kategoria == "antivírus" && s.Ertekeles > 8.5);
            Console.WriteLine($"{f7.Count()}db van belőle.");
            #endregion

            #region 8. feladat
            Console.WriteLine("8. feladat");
            var maxErtekeles = szoftverek.Max(s => s.Ertekeles) - .1;
            var f8 = szoftverek.Where(s => s.Ertekeles == maxErtekeles).ToList();
            f8.ForEach(sz => Console.WriteLine(sz));
            Console.WriteLine($"{f8.Count} db ilyen volt és az értékelésük {maxErtekeles}");
            #endregion

            #region 10. feladat
            var f10 = szoftverek.Where(s => s.NevVerzio.Contains("Adobe")).Average(s => s.Brutto);
            Console.WriteLine($"10. feladat Az átlagos bruttó az Adobe szoftvereknek: {f10}");
            #endregion

            #region 11. feladat
            var f11 = szoftverek.Where(s => s.OpRendszerek.Split(',').Length > 1).OrderBy(s => s.Kategoria).GroupBy(s => s.Kategoria).ToList();
            f11.ForEach(s => Console.WriteLine(s.Key));
            #endregion

            #region 12. feladat
            var f12 = szoftverek.Where(s => s.NettoAr > 500 && s.Ertekeles < 9).Select(s => s.Azonosito).ToList();
            f12.ForEach(s => Console.Write($"{s};"));
            #endregion

            #region 13. feladat
            using var sw = new StreamWriter(path: @"..\..\..\src\ujSzoftverek.txt");
            szoftverek.Where(s => s.LicencTipus == "fizetős").ToList().GetRange(0, 10).ForEach(s => sw.WriteLine(s));
            #endregion
        }
    }
}
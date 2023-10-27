using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szoftverek
{
    class Szoftver
    {
        public int Azonosito { get; init; }
        public string NevVerzio { get; init; }
        public string LicencTipus { get; init; }
        public string OpRendszerek { get; init; }
        public string Kategoria { get; init; }
        public double Ertekeles { get; init; }
        public double NettoAr { get; init; }
        public int Adokukcs { get; init; }

        public double Brutto => NettoAr + (NettoAr * (Adokukcs / 100));
        public Szoftver(string sor)
        {
            string[] s = sor.Split('|');

            Azonosito = int.Parse(s[0]);
            NevVerzio = s[1];
            LicencTipus = s[2];
            OpRendszerek = s[3];
            Kategoria = s[4];
            Ertekeles = double.Parse(s[5]);
            NettoAr = double.Parse(s[6]);
            Adokukcs = int.Parse(s[7]);

        }

        public override string ToString()
        {
            return $"Azonosító: {Azonosito}\n" +
                $"Név és verziószám: {NevVerzio}\n" +
                $"Licenc típus: {LicencTipus}\n" +
                $"Operációs rendszer(ek): {OpRendszerek}\n" +
                $"Szoftver kategóriája: {Kategoria}\n" +
                $"Felhasználói értékelés: {Ertekeles}\n" +
                $"Nettó ár: {NettoAr} USD\n" +
                $"Adókulcs: {Adokukcs}\n";
        }


    }
}

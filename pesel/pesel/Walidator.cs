using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesel
{
    public class PESELWalidator
    {
        protected int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        protected int[] pesel;
        

        public PESELWalidator(String pesel)
        {
            WczytajPesel(pesel);
        }

        public void WczytajPesel(String pesel)
        {
            this.pesel = pesel.Select(n => Int32.Parse(n.ToString())).ToArray();
        }

        public int SumaKontrolna()
        {
            var sum = 0;
            for (int i = 0; i < wagi.Length; i++)
            {
                sum += pesel[i] * wagi[i];

            }
            sum = (10 - (sum % 10) % 10);
            return sum;
        }

        public String DataUrodzenia()
        {
            return $"{pesel[4]}{pesel[5]}/{pesel[2]}{pesel[3]}/19{pesel[0]}{pesel[1]}";
            

        }

        public String Plec()
        {
            return pesel[10] % 2 == 0 ? "K" : "M";
        }

        public Boolean SprawdzPesel()
        {
            if (10 - SumaKontrolna() % 10 == pesel[10])
            { return true; }
            else
                return false;
        }

    }
}

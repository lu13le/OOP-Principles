using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonWeek1LukaRaicevic
{
    class Auto : Vozilo
    {
        #region atributi
        private string marka;
        private int brojSedista;
        #endregion

        #region konstruktori
        public Auto(string marka, int brojSedista,string boja,float brzina, float maxBrzina):base(boja,brzina,maxBrzina)
        {
            this.marka = marka;
            this.brojSedista = brojSedista;
        }

        #endregion

        #region Funkcije

        public override void ubrzaj()
        {
            if (moguceUbrzanje() > 50)
                getSetBrzina += 20;
            else if (getSetBrzina + 10 >= getSetMaxBrzina)
                getSetBrzina = getSetMaxBrzina;
            else
                getSetBrzina += 10;
        }

        public override void uspori()
        {
            if (brojSedista == 2)
                getSetBrzina -= 30;
            else
                getSetBrzina -= 15;
        }

        public override void unos()
        {
            Console.WriteLine("Unesite marku auta: ");
            marka = Console.ReadLine();

            Console.WriteLine("Unesite broj sedista auta: ");
            brojSedista = Convert.ToInt32(Console.ReadLine());

            base.unos();

        }

        public override string ToString()
        {
            return $"AUTO\nMarka auta: {marka}\nBroj sedista auta:{brojSedista}\n{base.ToString()}\n";
        }
        #endregion
    }
}

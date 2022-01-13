using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkvelonWeek1LukaRaicevic
{
    abstract class Vozilo
    {
        #region atributi
        private string boja;
        private float brzina;
        private float maxBrzina;
        #endregion

        #region Konstruktori
        public Vozilo(string boja, float brzina, float maxBrzina)
        {
            this.boja = boja;
            this.brzina = brzina;
            this.maxBrzina = maxBrzina;
        }
        #endregion

        #region polja

        public float getSetBrzina
        {
            get { return brzina; }
            set { brzina = value; }
        }
        public float getSetMaxBrzina
        {
            get { return maxBrzina; }
            set { maxBrzina = value; }
        }
        #endregion

        #region funkcije
        public float moguceUbrzanje()
        {
            return maxBrzina - brzina;
        }

        public abstract void ubrzaj();

        public abstract void uspori();

        public virtual void unos()
        {
            Console.WriteLine("Unesite boju: ");
            boja = Console.ReadLine();

            Console.WriteLine("Unesite brzinu kretanja vozila: ");
            brzina = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Unesite maksimalnu brzinu: ");
            maxBrzina = Convert.ToSingle(Console.ReadLine());

        }

        public override string ToString()
        {
            return $"Boja vozila: {boja}\nBrzina kretanja vozila:{brzina}\nMaksimalna brzina vozila je: {maxBrzina}\n";
        }
        #endregion
    }
}

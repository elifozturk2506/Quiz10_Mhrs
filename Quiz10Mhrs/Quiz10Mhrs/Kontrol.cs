using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz10Mhrs
{
    abstract class Kontrol
    {

        static DateTime randevutarihi;

        public static DateTime Randevutarihi
        {
            get { return Kontrol.randevutarihi; }
            set { Kontrol.randevutarihi = value; }
        }
        static string randevusaati;

        public static string Randevusaati
        {
            get { return Kontrol.randevusaati; }
            set { Kontrol.randevusaati = value; }
        }
        static int randevupersonelid;

        public static int Randevupersonelid
        {
            get { return Kontrol.randevupersonelid; }
            set { Kontrol.randevupersonelid = value; }
        }
        static int ilgiliHastaId;

        public static int IlgiliHastaId
        {
            get { return Kontrol.ilgiliHastaId; }
            set { Kontrol.ilgiliHastaId = value; }
        }

        static string ilgiliHastaTc;

        public static string IlgiliHastaTc
        {
            get { return Kontrol.ilgiliHastaTc; }
            set { Kontrol.ilgiliHastaTc = value; }
        }
        static string ilgiliHastaAd;

        public static string IlgiliHastaAd
        {
            get { return Kontrol.ilgiliHastaAd; }
            set { Kontrol.ilgiliHastaAd = value; }
        }
        static string ilgiliHastaSoyad;

        public static string IlgiliHastaSoyad
        {
            get { return Kontrol.ilgiliHastaSoyad; }
            set { Kontrol.ilgiliHastaSoyad = value; }
        }
        static int ilgiliDoktorId;

        public static int IlgiliDoktorId
        {
            get { return Kontrol.ilgiliDoktorId; }
            set { Kontrol.ilgiliDoktorId = value; }
        }
       
      public abstract int hastagiris(string tc, string sifre);
      public abstract int doktorgiris(string tc);
      public abstract bool tcuygunmu(string tc);
      public abstract bool sifresyntaxuygunmu(string sifre);
      public abstract bool sifreleruyusuyormu(string sifre, string sifrekontrol);
      public abstract bool tcsifreuyusuyormu(string tc, string sifre);
      public abstract bool tcvalidmi(string tc);
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz10Mhrs
{
    class KontrolImpl:Kontrol
    {
        static int doktorid = 0;
        static int  hastaid=0;
        static string tc = "";
        static string ad = "";
        static string soyad = "";
        public override int hastagiris(string tc, string sifre)
        {
            
            SqlConnection con = new SqlConnection("SERVER=.;DATABASE=MhrsDB;Trusted_connection=True;");
            SqlCommand com = new SqlCommand("select HastaId,Tc,RTRIM(Ad),RTRIM(Soyad) from Hasta where Tc=@tc and Password=@sifre", con);
            com.Parameters.AddWithValue("@tc", tc);
            com.Parameters.AddWithValue("@sifre", sifre);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        hastaid = dr.GetInt32(0);
                        tc = dr.GetString(1);
                        ad = dr.GetString(2);
                        soyad = dr.GetString(3);
                        Kontrol.IlgiliHastaId = hastaid;
                        Kontrol.IlgiliHastaTc = tc;
                        Kontrol.IlgiliHastaAd = ad;
                        Kontrol.IlgiliHastaSoyad = soyad;
                    }
                }
            }
            return hastaid;
        }

        public override bool tcuygunmu(string tc)
        {
            if (tc.Length == 11)
            {
                return true;
            }
            return false;
        }

        public override bool sifresyntaxuygunmu(string sifre)
        {
            int harfsay = 0;
            int rakamsay = 0;
            int ozelkaraktersay = 0;
            string rakamlar = "0123456789";
            string harfler = "abcçdefgğhıijklmnoöprsştuüvyzwqxABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZWQX";
            string ozelkarakter = "!+.,:;+-*/?-_<>^#%&()[]=}{\"";
            for (int i = 0; i < sifre.Length; i++)
            {

                for (int j = 0; j < rakamlar.Length; j++)
                {
                    if (sifre[i] == rakamlar[j])
                    {
                        rakamsay++;
                    }
                }
                for (int k = 0; k < harfler.Length; k++)
                {
                    if (sifre[i] == harfler[k])
                    {
                        harfsay++;
                    }
                }
                for (int m = 0; m < ozelkarakter.Length; m++)
                {
                    if (sifre[i] == ozelkarakter[m])
                    {
                        ozelkaraktersay++;
                    }
                }

            }
            if (harfsay != 0 && rakamsay != 0 && ozelkaraktersay != 0)
            {
                return true;
            }

            return false;
        }

        public override bool sifreleruyusuyormu(string sifre, string sifrekontrol)
        {
            if (sifre == sifrekontrol)
            {
                return true;
            }
            return false;
        }

        public override bool tcsifreuyusuyormu(string tc, string sifre)
        {
            throw new NotImplementedException();
        }

        public override bool tcvalidmi(string tc)
        {
            return false;
        }

        public override int doktorgiris(string tc)
        {
          
            SqlConnection con = new SqlConnection("SERVER=.;DATABASE=MhrsDB;Trusted_connection=True;");
            SqlCommand com = new SqlCommand("select PersonelId from Personel where PersonelTipId=8 and Tc=@tc", con);
            com.Parameters.AddWithValue("@tc", tc);
          
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        doktorid = dr.GetInt32(0);

                        Kontrol.IlgiliDoktorId = doktorid;
                    }
                }
            }
            return doktorid;
        }
    }
}

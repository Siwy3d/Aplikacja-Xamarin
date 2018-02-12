using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BMIaplikacja
{
    public static class ObliczanieBMR
    {
       public static double wynik;
        public static void ObliczBMR (string waga,string wzrost,string wiek, double aktywnosc,char plec)
        {
            
           
            double w = double.Parse(waga);
            double wz = double.Parse(wzrost);
            double wi = double.Parse(wiek);
           if (plec=='k')
            {
                wynik = (9.99 * w) + (6.25 * wz) - (4.92 * wi) - 161;
            }
           else if (plec=='m')
            {
                wynik = (9.99 * w) + (6.25 * wz) - (4.92 * wi) + 5;
            }
            wynik = wynik * aktywnosc;
           

        }
        
    }
}
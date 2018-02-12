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
    [Activity(Label = "Twój Wynik")]
    public class WynikActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Wynik);

            TextView wynik = FindViewById<TextView>(Resource.Id.wynik);

            wynik.Text = ObliczanieBMR.wynik.ToString()+" (kcal)";
           
           
        }
    }
}
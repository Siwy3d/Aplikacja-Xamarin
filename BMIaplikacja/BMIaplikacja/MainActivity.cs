using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System;
using Android.Content;

namespace BMIaplikacja
{
    [Activity(Label = "Aplikacja BMR", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private void RadioButtonClick(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Id == 2130968585) { _plec = 'k'; }
           else if (rb.Id == 2130968586) { _plec = 'm'; }
           else if (rb.Id == 2130968589) { _aktywnosc = 1.2; }
           else if (rb.Id == 2130968590) { _aktywnosc = 1.4; }
           else if (rb.Id == 2130968591) { _aktywnosc = 1.6; }
           else if (rb.Id == 2130968592) { _aktywnosc = 1.8; }
           else if (rb.Id == 2130968593) { _aktywnosc = 2.0; }

        }
       public string _wiek = "";
       public string _wzrost= "";
       public string _waga="";
       public double _aktywnosc=0;
       public char _plec='*';



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            EditText podanawaga = FindViewById<EditText>(Resource.Id.podanaWaga);
            EditText podanywzrost = FindViewById<EditText>(Resource.Id.podanyWzrost);
            EditText podanywiek = FindViewById<EditText>(Resource.Id.podanyWiek);

            RadioButton kobieta = FindViewById<RadioButton>(Resource.Id.radioKobieta);
            RadioButton mezczyzna = FindViewById<RadioButton>(Resource.Id.radiomezczyna);

            RadioButton aktywnosc1 = FindViewById<RadioButton>(Resource.Id.radioaktyw1);
            RadioButton aktywnosc2 = FindViewById<RadioButton>(Resource.Id.radioaktyw2);
            RadioButton aktywnosc3 = FindViewById<RadioButton>(Resource.Id.radioaktyw3);
            RadioButton aktywnosc4 = FindViewById<RadioButton>(Resource.Id.radioaktyw4);
            RadioButton aktywnosc5 = FindViewById<RadioButton>(Resource.Id.radioaktyw5);

            TextView wynik = FindViewById<TextView>(Resource.Id.wynik);

            Button obliczbutton = FindViewById<Button>(Resource.Id.buttonsprawdz);

            

            mezczyzna.Click += RadioButtonClick;
            kobieta.Click += RadioButtonClick;
            aktywnosc1.Click += RadioButtonClick;
            aktywnosc2.Click += RadioButtonClick;
            aktywnosc3.Click += RadioButtonClick;
            aktywnosc4.Click += RadioButtonClick;
            aktywnosc5.Click += RadioButtonClick;

           




            obliczbutton.Click += (sender, e) =>
            {
                
                _waga = podanawaga.Text;
                _wzrost = podanywzrost.Text;
                _wiek = podanywiek.Text;
                if (string.IsNullOrWhiteSpace(_waga) || string.IsNullOrWhiteSpace(_wzrost) || string.IsNullOrWhiteSpace(_wiek) || _aktywnosc == 0 || _plec == '*')
                {
                    Toast.MakeText(this, "Wszystkie pola muszą być wypełnione", ToastLength.Short).Show();
                }
                else
                {
                    if (int.Parse(_waga) <= 30 || int.Parse(_waga) >= 250)
                    {
                        Toast.MakeText(this, "Podana waga jest nieprawidłowa", ToastLength.Short).Show();
                    }
                    else if (int.Parse(_wzrost) <= 100 || int.Parse(_wzrost) >= 250)
                    {
                        Toast.MakeText(this, "Podany wzrost jest nieprawidłowy", ToastLength.Short).Show();
                    }
                    else if (int.Parse(_wiek) < 18 || int.Parse(_wiek) > 100)
                    {
                        Toast.MakeText(this, "Podany wiek jest nieprawidłowy", ToastLength.Short).Show();
                    }
                    else
                    {
                        ObliczanieBMR.ObliczBMR(_waga, _wzrost, _wiek, _aktywnosc, _plec);


                        var intent = new Intent(this, typeof(WynikActivity));
                        StartActivity(intent);
                    }
                }


            };
            

        }

       
    }
}


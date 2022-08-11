using Java.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WinDateCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            data.Date = DateTime.Parse(Preferences.Get("Data", DateTime.Now.ToString()));
        }

        private void calcola_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            TimeSpan differenza = data.Date.Date-d;
            risultato.Text ="Mancano " + differenza.Days + " giorni.";
            Preferences.Set("Data", data.Date.Date.ToString());
        }
    }
}

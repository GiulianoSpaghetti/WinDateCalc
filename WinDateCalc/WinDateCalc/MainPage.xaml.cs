using Java.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WinDateCalc
{
    public partial class MainPage : ContentPage
    {
        private static MyUserSettings mus = new MyUserSettings();
        public MainPage()
        {
            InitializeComponent();
            data.Date = mus.data.Date;
        }

        private void calcola_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            TimeSpan differenza = data.Date.Date-d;
            risultato.Text ="Mancano " + differenza.Days + " giorni.";
            mus.data = data.Date;
            mus.Save();
        }
    }
}

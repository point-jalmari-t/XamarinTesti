using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTesti
{
    public partial class MainPage : ContentPage
    {
        private int oikeaLuku;

        public MainPage()
        {
            InitializeComponent();
            Random rnd = new Random();
            oikeaLuku = rnd.Next(1, 11);
        }
        private void GoNappi_clicked(object sender, EventArgs e)
        {
            int arvaus = int.Parse(syötekenttä.Text);
            if (arvaus < oikeaLuku)
            {
                arvauksenTulosLabel.Text = "luku on suurempi";
            }
            else if (arvaus > oikeaLuku)
            {
                arvauksenTulosLabel.Text = "luku on pienempi";
            }
            else if (arvaus == oikeaLuku)
            {
                arvauksenTulosLabel.Text = "oikein";
            }
        }
    }
}

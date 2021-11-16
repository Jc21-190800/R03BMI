using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A07 利部　慶悟";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var height = heighit.Text;
            var waight = weighit.Text;
            try
            {
                double h = double.Parse(height);
                double w = double.Parse(waight);
                if (h > 10)
                {
                    h = h / 100;
                }

                heighit.Text = "身長" + h + "," + "体重" + w + "の人のBMIは" + "";


            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                heighit.Text = "!!!";
            }
        }
    }
}

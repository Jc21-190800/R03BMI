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
                double BM;
                double BMI;
                if (h > 10)
                {
                    h = h / 100;
                }else if (w > 1000)
                {
                    w = w/1000;
                }
                BM=h*h;
                BMI = w/BM;
                double BMI2 = Math.Round(BMI, 1, MidpointRounding.AwayFromZero);   

   

                if (BMI2 < 18.5)
                {
                    result.Text="低体重(痩せ)"+"でBMIは"+ BMI2;
                }else if (BMI2 < 25.0)
                {
                    result.Text="普通体重"+"でBMIは"+ BMI2;
                }else if (BMI2 < 30.0)
                {
                    result.Text="肥満 (1度)"+"でBMIは"+ BMI2;
                }else if (BMI2 < 35.0)
                {
                    result.Text="肥満 (2度)"+"でBMIは"+ BMI2;
                }else if (BMI2 < 40.0)
                {
                    result.Text="肥満 (3度)"+"でBMIは"+ BMI2;
                }else if (BMI2 >= 40.0)
                {
                    result.Text="肥満 (4度)"+"でBMIは"+ BMI2;
                }


            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                heighit.Text = "!!!";
            }
        }
    }
}

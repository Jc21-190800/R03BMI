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
                if (BMI < 18.5)
                {
                    result.Text="低体重(痩せ)";
                }else if (BMI < 25.0)
                {
                    result.Text="普通体重";
                }else if (BMI < 30.0)
                {
                    result.Text="肥満 (1度)";
                }else if (BMI < 35.0)
                {
                    result.Text="肥満 (2度)";
                }else if (BMI < 40.0)
                {
                    result.Text="肥満 (3度)";
                }else if (BMI >= 40.0)
                {
                    result.Text="肥満 (4度)";
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

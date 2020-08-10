using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace hello
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            value = 0;
        }
        private int value = 0;
        void Handle_Click1(System.Object sender, System.EventArgs e)
        {
            button1.BackgroundColor = Color.Red;
            button2.Opacity = 0;
            button2.IsEnabled = false;
            value = 0;
            amountLabel.Text = "$" + value.ToString("0.00");

        }

        async void Handle_Click2(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Box 2 Alert", "Hello World", "OK");
        }       

        void Handle_Click3(System.Object sender, System.EventArgs e)
        {
            value += 10;
            amountLabel.Text = "$ " + value.ToString("0.00");
            conditionCheck(value);
        }       

        void Handle_Click4(System.Object sender, System.EventArgs e)
        {
            value -= 10;
            amountLabel.Text = "$ " + value.ToString("0.00");
            conditionCheck(value);
        }
        void conditionCheck(int value)
        {
            if(value == 40 || value == 50)
            {
                button1.BackgroundColor = Color.Green;
                button2.IsEnabled = true;
                button2.Opacity = 1;
                Grid.SetColumn(button1, 1);
                Grid.SetColumn(button2, 0);

            }
            else
            {
                button1.BackgroundColor = Color.LightSkyBlue;
                button2.IsEnabled = false;
                button2.Opacity = 0;
                Grid.SetColumn(button1, 0);
                Grid.SetColumn(button2, 1);
            }
        }
       
    }
}

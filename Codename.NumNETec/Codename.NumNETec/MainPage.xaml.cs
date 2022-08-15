using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Codename.NumNETec
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btn1.Text;
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btn2.Text;
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btn3.Text;
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btn7.Text;
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btn4.Text;
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btn5.Text;
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btn6.Text;
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btn8.Text;
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btn9.Text;
        }

        private void plus_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + plus.Text;
        }

        private void divide_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + divide.Text;
        }

        private void multiply_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + multiply.Text;
        }

        private void deduct_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + deduct.Text;
        }

        private void equals_Clicked(object sender, EventArgs e)
        {
            ErrorProvider.Text = string.Empty;
            try
            {
                DataTable dataTable = new DataTable();
                var final = dataTable.Compute(MainCalcInput.Text, string.Empty);
                MainCalcInput.Text = final.ToString();
            }
            catch
            {
                ErrorProvider.Text = "SYNTAX ERROR";
                ErrorProvider.TextColor = Color.DarkRed;
                MainCalcInput.Text = string.Empty;
            }

        }

        private void C_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = string.Empty;
        }

        private void btn0_Clicked(object sender, EventArgs e)
        {
            MainCalcInput.Text = MainCalcInput.Text + btnOmega.Text;
        }

        private void MainCalcInput_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }
    }
}

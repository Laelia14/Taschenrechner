using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Clear();
        }
        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "0";
        }
        private void Button_Result_Click(object sender, RoutedEventArgs e)
        {

            try {
            string[] result = Textfeld_Result.Text.Split(" ");
            int numberOne = Convert.ToInt32(result[0]);
            int numberTwo = Convert.ToInt32(result[2]);
            string arithmeticOperator = result[1];
            if (arithmeticOperator == "+")
            {
                int additionResult = numberOne + numberTwo;
                Textfeld_Result.Text = additionResult.ToString();
            }
            if (arithmeticOperator == "-")
            {
                int subtractitionResult = numberTwo - numberOne;
                Textfeld_Result.Text = subtractitionResult.ToString();
            }
            if (arithmeticOperator == "/")
            {
                int divisionResult = numberOne / numberTwo;
                Textfeld_Result.Text = divisionResult.ToString();
            }
                if (arithmeticOperator == "*")
                {
                    int multiplicationResult = numberTwo * numberOne;
                    Textfeld_Result.Text = multiplicationResult.ToString();
                }
            } catch (Exception)
            {
                Textfeld_Result.Text = "Error";
            }
        }
        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + " + ";
        }
        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + " - ";
        }
        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "3";
        }
        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "2";
        }
        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "1";
        }
        private void Button_Geteilt_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + " / ";
        }
        private void Button_Mal_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + " × ";
        }
        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "6";
        }
        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "5";
        }
        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "4";
        }
        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "9";
        }
        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "8";
        }
        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            Textfeld_Result.Text = Textfeld_Result.Text + "7";
        }
        private void Button_E_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Textfeld_Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

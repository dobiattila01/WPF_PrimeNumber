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

namespace WPF_Primszam
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


        public int Size { get; set; }
        static bool prime(int a)
        {
            if (a % 2 == 0 || a==1) return false;
            //int h = Convert.ToInt32(Math.Sqrt(a));
            for(int i=3; i<((int)(Math.Sqrt(a))); i+=2)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        private void generatePrime_button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            Size = int.Parse(generatedPrimeElement_textbox.Text);
            int[] numbers = new int[Size];
            textBox.AppendText(2 +", ");
            for (int i = 1; i < numbers.Length; i++)
            {
                if (prime(i)) textBox.AppendText(i + ", ");
            }


            //textBox.AppendText("2, 5, 7, ");
            //for (int i = 3; i < numbers.Length; i++)
            //{
            //    prim = true;
            //    if (i % 2 == 0) prim = false;

            //    for (int j = 3; j <=Math.Sqrt((double)(i)) && prim==true; j+=2)
            //    {
            //        if (i % j == 0) prim = false;
            //        if (prim == true) textBox.AppendText(numbers[i] + ", "); 
            //    }

            //}



            //textBox.AppendText
            //if (!(numbers[i] % 2 == 0 || numbers[i] % 3 == 0 || numbers[i] % 5 == 0 || numbers[i] % 7 == 0) && numbers[i] !=1)
            //{
            //    textBox.AppendText(numbers[i] + ", ");
            //}
        }
        //foreach (int item in numbers)
        //{
        //    textBox.AppendText(item + ", ");
        //}
    }
}


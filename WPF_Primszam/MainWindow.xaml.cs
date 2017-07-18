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
        static bool IsPrim(int a)
        {
            if (a % 2 == 0 || a==1) return false;
            for(int i=3; i<((int)(Math.Sqrt(a))); i+=2)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        private void generatePrime_button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            if (generatedPrimeElement_textbox.Text == "")
            {
                textBox.Text = "Please write a number the generate button next to in field!";
                return;
            }
            Size = int.Parse(generatedPrimeElement_textbox.Text);
            int[] numbers = new int[Size];
            textBox.AppendText(2 +", ");
            for (int i = 1; i < numbers.Length; i++)
            {
                if (IsPrim(i)) textBox.AppendText(i + ", ");
            }
        }        
    }
}


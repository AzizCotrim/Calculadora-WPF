using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
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

        private void Button0_Click(object sender, RoutedEventArgs e) {
            Adicionar("0");
        }

        private void Button1_Click(object sender, RoutedEventArgs e) {
            Adicionar("1");
        }

        private void Button2_Click(object sender, RoutedEventArgs e) {
            Adicionar("2");
        }

        private void Button3_Click(object sender, RoutedEventArgs e) {
            Adicionar("3");
        }

        private void Button4_Click(object sender, RoutedEventArgs e) {
            Adicionar("4");
        }

        private void Button5_Click(object sender, RoutedEventArgs e) {
            Adicionar("5");
        }

        private void Button6_Click(object sender, RoutedEventArgs e) {
            Adicionar("6");
        }

        private void Button7_Click(object sender, RoutedEventArgs e) {
            Adicionar("7");
        }

        private void Button8_Click(object sender, RoutedEventArgs e) {
            Adicionar("8");
        }

        private void Button9_Click(object sender, RoutedEventArgs e) {
            Adicionar("9");
        }

        private void ButtonDecimal_Click(object sender, RoutedEventArgs e) {
            Adicionar(",");
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e) {
            Adicionar("+");
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e) {
            Adicionar("-");
        }

        private void ButtonMulti_Click(object sender, RoutedEventArgs e) {
            Adicionar("*");
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e) {
            Adicionar("/");
        }

        private void ButtonPerCent_Click(object sender, RoutedEventArgs e) {
        
        }

        private void ButtonParent_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonTotal_Click(object sender, RoutedEventArgs e) {
            string padrao = @"(?<=[*\/+\-])|(?=[*\/+\-])";
            string display = Display.Content.ToString();
            display = display.Replace(',','.');

            List<string> tokens = Regex.Split(display, padrao)
                                       .Where(s => !string.IsNullOrEmpty(s))
                                       .ToList();
            
            foreach(string x in tokens) {
                TestList.Content += $"{x},";
            }

            for (int i = 0; i < tokens.Count(); i++) {
                if (tokens[i] == "*") {
                    decimal x = decimal.Parse(tokens[i - 1]);
                    decimal y = decimal.Parse(tokens[i + 1]);

                    string result = Mult(x, y).ToString();

                    tokens.RemoveAt(i + 1);
                    tokens.RemoveAt(i);
                    tokens.RemoveAt(i - 1);

                    tokens.Insert(i - 1, result);

                    i = -1;

                }else if (tokens[i] == "/") {
                    decimal x = decimal.Parse(tokens[i - 1]);
                    decimal y = decimal.Parse(tokens[i + 1]);

                    if (y == 0)
                        return;

                    string result = Div(x, y).ToString();

                    tokens.RemoveAt(i+1);
                    tokens.RemoveAt(i);
                    tokens.RemoveAt(i-1);

                    tokens.Insert(i - 1, result);

                    i = -1;

                } 
            }

            for (int i = 0; i < tokens.Count(); i++) {
                if (tokens[i] == "+") {
                    decimal x = decimal.Parse(tokens[i - 1]);
                    decimal y = decimal.Parse(tokens[i + 1]);

                    string result = Soma(x, y).ToString();

                    tokens.RemoveAt(i + 1);
                    tokens.RemoveAt(i);
                    tokens.RemoveAt(i - 1);

                    tokens.Insert(i - 1, result);

                    i = -1;

                } else if (tokens[i] == "-") {
                    decimal x = decimal.Parse(tokens[i - 1]);
                    decimal y = decimal.Parse(tokens[i + 1]);

                    if (y == 0)
                        return;

                    string result = Sub(x, y).ToString();

                    tokens.RemoveAt(i + 1);
                    tokens.RemoveAt(i);
                    tokens.RemoveAt(i - 1);

                    tokens.Insert(i - 1, result);

                    i = -1;

                }
            }

            Display.Content = tokens[0].Replace('.', ',');
        }

        private void ButtonClean_Click(object sender, RoutedEventArgs e) {
            Display.Content = "";
        }

        private void Adicionar(string x) {
            string content = Display.Content.ToString();
            content += x;
            Display.Content = content;
        }

        private decimal Soma(decimal x, decimal y) {
            decimal t = x + y;
            return t;
        }

        private decimal Sub(decimal x, decimal y) {
            decimal t = x - y;
            return t;
        }

        private decimal Mult(decimal x, decimal y) {
            decimal t = x * y;
            return t;
        }

        private decimal Div(decimal x, decimal y) {
            decimal t = x / y;
            return t;
        }
    }
}
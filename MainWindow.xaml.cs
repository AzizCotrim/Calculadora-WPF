using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

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
            char[] operadores = ['+', '-', '*', '/'];
            string display = Display.Content.ToString();
            var result = display.FirstOrDefault(x => operadores.Contains(x));

            string[] separado = display.Split(operadores);
            decimal[] numeros = separado.Select(s => decimal.Parse(s ,new CultureInfo("pt-BR"))).ToArray();
            switch (result) {
                case '+':
                    Display.Content = Soma(numeros[0], numeros[1]);
                    break;

                case '-':
                    Display.Content = Sub(numeros[0], numeros[1]);
                    break;

                case '*':
                    Display.Content = Mult(numeros[0], numeros[1]);
                    break;

                case '/':
                    Display.Content = Div(numeros[0], numeros[1]);
                    break;
            }
        }

        private void ButtonClean_Click(object sender, RoutedEventArgs e) {
            Display.Content = "";
        }

        private void Adicionar(string x) {
            string content = Display.Content.ToString();
            content += x;
            Display.Content = content;
        }

        private string Soma(decimal x, decimal y) {
            decimal t = x + y;
            return t.ToString(new CultureInfo("pt-BR"));
        }

        private string Sub(decimal x, decimal y) {
            decimal t = x - y;
            return t.ToString(new CultureInfo("pt-BR"));
        }

        private string Mult(decimal x, decimal y) {
            decimal t = x * y;
            return t.ToString(new CultureInfo("pt-BR"));
        }

        private string Div(decimal x, decimal y) {
            decimal t = x / y;
            return t.ToString(new CultureInfo("pt-BR"));
        }
    }
}
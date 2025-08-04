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
            AdicionarNum("0");
        }

        private void Button1_Click(object sender, RoutedEventArgs e) {
            AdicionarNum("1");
        }

        private void Button2_Click(object sender, RoutedEventArgs e) {
            AdicionarNum("2");
        }

        private void Button3_Click(object sender, RoutedEventArgs e) {
            AdicionarNum("3");
        }

        private void Button4_Click(object sender, RoutedEventArgs e) {
            AdicionarNum("4");
        }

        private void Button5_Click(object sender, RoutedEventArgs e) {
            AdicionarNum("5");
        }

        private void Button6_Click(object sender, RoutedEventArgs e) {
            AdicionarNum("6");
        }

        private void Button7_Click(object sender, RoutedEventArgs e) {
            AdicionarNum("7");
        }

        private void Button8_Click(object sender, RoutedEventArgs e) {
            AdicionarNum("8");
        }

        private void Button9_Click(object sender, RoutedEventArgs e) {
            AdicionarNum("9");
        }

        private void ButtonDecimal_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonMulti_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonPerCent_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonParent_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonTotal_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonClean_Click(object sender, RoutedEventArgs e) {
            Display.Content = "";
        }

        private void AdicionarNum(string num) {
            string content = Display.Content.ToString();
            content += num;
            Display.Content = content;
        }
    }
}
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
using static System.Net.Mime.MediaTypeNames;

namespace CalcWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;

        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (TxtResult.Text.Length < 1 && int.TryParse(btn.Content.ToString(), out int newDigit))
            {
                if (newDigit >= 1 && newDigit <= 9)
                {
                    TxtResult.Text += newDigit.ToString();
                    second = newDigit;
                }
            }
        }


        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '/';
            TxtResult.Clear();
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '*';
            TxtResult.Clear();
        }

        private void subButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '-';
            TxtResult.Clear();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '+';
            TxtResult.Clear();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(TxtResult.Text);
            int result = 0;


            if (op == '+')
            {
                result = first + second;
            }
            else if (op == '-')
            {
                result = first - second;
            }
            else if (op == '*')
            {
                result = first * second;
            }
            else if (op == '/')
            {
                result = first / second;
            }
            if (TxtResult.Text == "0")
            {
                TxtResult.Clear();
            }
            TxtResult.Text = result.ToString();
        }


        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            first = 0;
            second = 0;
            op = '\0';
            TxtResult.Clear();
        }
    }
}
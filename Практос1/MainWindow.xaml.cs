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
using Lib_10;

namespace Практос1
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
        //Кнопка закрытия програмыы
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Кнопка вывода информации о программе
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вычислить сумму целых случайных чисел, распределенных в диапазоне от 5 до 10, пока эта сумма не превышает некоторого числа K. Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел. \nРазработчик: Вера И Шевелева Мария-Элисабет ИСП-31");
        }
        //Кнопка расчета
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            bool f = Int32.TryParse(tbK.Text, out int value);
            if (f == true && value > 0)
            {
                int rez;
                int col;
                string chisla;
                int k = Convert.ToInt32(tbK.Text);
                CalculatingSum.Sum(value, out col, out rez, out chisla);
                tbChisla.Text = chisla;
                tbKol.Text = Convert.ToString(col);
                tbResult.Text = Convert.ToString(rez);
            }
            else MessageBox.Show("Введите корректное значение ");
        }

        //Кнопка очистки
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbChisla.Clear();
            tbKol.Clear();
            tbResult.Clear();
            tbK.Clear();
            tbK.Focus();
        }
    }
}
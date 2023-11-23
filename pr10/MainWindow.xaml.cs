using pr10;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace pr10
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> numbers;
        public MainWindow()
        {
            InitializeComponent();
            numbers = new ObservableCollection<int>();

        }
        private void btnCalculate_click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb_ot.Text, out int A) && int.TryParse(tb_do.Text, out int B))
            {
                if (B > A & A >= -100 & B <= 100)
                {
                    lab_intervel.Content = $"Числа от {A} до {B}";
                    int evenCount = 0;
                    int oddCount = 0;
                    int[] array = (GenerateRandom.GenerateRandomArray(A, B));
                    for (int i = 0; i < array.Length; i++)
                    {
                        numbers.Add(array[i]);
                    }

                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            evenCount++; // Увеличиваем счетчик четных чисел
                        }
                        else
                        {
                            oddCount++; // Увеличиваем счетчик нечетных чисел
                        }
                    }
                    for (int j = 0; j < array.Length; j++)
                    {
                        lb_num.Items.Add(array[j]);
                    }

                    lb_calc.Items.Add($"Количество четных чисел: {evenCount}\r\nКоличество нечетных чисел: {oddCount}");
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lb_num.Items.Clear();
            lb_calc.Items.Clear();
            tb_ot.Text = "";
            tb_do.Text = "";
            numbers.Clear();
            lab_intervel.Content = "";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Инфа");
        }

        private void TextCh(object sender, TextChangedEventArgs e)
        {
            lb_calc.Items.Clear();
            lb_num.Items.Clear();
        }
    }
}

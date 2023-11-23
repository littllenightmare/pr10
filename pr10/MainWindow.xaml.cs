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
    //Проверь класс, проверь форейк
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
            int evenCount = 0;
            int oddCount = 0;
            int[] array = GenerateRandom.GenerateRandomArray(-100, 100);
            for (int i = 0; i < array.Length; i++)
            {
                numbers.Add(array[i]);
            }
            //Че такое форейк (заменить на попроще?)
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lb_num.Items.Clear();
            lb_calc.Items.Clear();
            numbers.Clear();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кулькова А ИСП-31 \r\nДан массив в диапазоне [-100;100] найти количество четных и нечетных.");
        }
    }
}

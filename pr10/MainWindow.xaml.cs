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

        private void TextCh(object sender, TextChangedEventArgs e)
        {
            calclb.Items.Clear();
            numlb.Items.Clear();
        }

        private void infoClick(object sender, RoutedEventArgs e)
        {
          MessageBox.Show("Выполнено Кульковой А\r\nДан массив в диапазоне [-100;100] найти количество четных и нечетных. ");
        }

        private void CalcClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(ottb.Text, out int A) & int.TryParse(dotb.Text, out int B))
            {
                if (B > A & A >= -100 & B <= 100)
                {
                    int evenCount = 0;
                    int oddCount = 0;
                    int[] mas = (GenerateRandom.GenerateRandomArray(A, B));
                    for (int i = 0; i < mas.Length; i++)
                    {
                        numbers.Add(mas[i]);
                        numlb.Items.Add(mas[i]);
                    }

                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            evenCount++;
                        }
                        else
                        {
                            oddCount++;
                        }
                    }

                    calclb.Items.Add($"Количество четных чисел: {evenCount}\r\nКоличество нечетных чисел: {oddCount}");
                }
            }
        }

        private void clearClick(object sender, RoutedEventArgs e)
        {
            numlb.Items.Clear();
            calclb.Items.Clear();
            ottb.Text = "";
            dotb.Text = "";
            numbers.Clear();
        }

        private void exClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

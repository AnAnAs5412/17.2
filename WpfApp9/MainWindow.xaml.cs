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
using System.Windows.Threading;

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private int color = 1;  //начальный цвет кнопки
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            Color_Buttom(); //реализация метода
            timer = new DispatcherTimer(); //добавление таймера
            timer.Interval = TimeSpan.FromSeconds(1); //установка интервала в 1 секунду
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Color_Buttom() // метод для задания цвета кнопкам
        {
            switch (color)
            {
                case 1: //красная кнопка
                    Red.Background = Brushes.Red;
                    Yellow.Background = Brushes.Gray;
                    Green.Background = Brushes.Gray;
                    break;
                case 2: //желтая кнопка
                    Red.Background = Brushes.Gray;
                    Yellow.Background = Brushes.Yellow;
                    Green.Background = Brushes.Gray;
                    break;
                case 3: //зеленая кнопка
                    Red.Background = Brushes.Gray;
                    Yellow.Background = Brushes.Gray;
                    Green.Background = Brushes.Green;
                    break;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            color = (color + 1) % 4; //переключение цветов по таймеру
            Color_Buttom();
        }
    }
}
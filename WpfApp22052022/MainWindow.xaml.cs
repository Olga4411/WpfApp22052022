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

namespace WpfApp22052022
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //1 Создали объект аниме
            var Anime = new System.Windows.Media.Animation.DoubleAnimation();
            // свойство to иfrom
            Anime.To = 100;
            Anime.From = 180;
            Anime.Duration = TimeSpan.FromSeconds(5);// время в секундах
            button.BeginAnimation(Button.WidthProperty, Anime);// какое свойство будет анимироваться ширина или высота

        }

        private void picture_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
             var Anime = new System.Windows.Media.Animation.DoubleAnimation();
            
            Anime.To = 250;
            Anime.From = 100;
            Anime.Duration = TimeSpan.FromSeconds(10);// время в секундах
            picture.BeginAnimation(Image.WidthProperty, Anime);
            picture.BeginAnimation(Image.HeightProperty, Anime);
        }
    }
}

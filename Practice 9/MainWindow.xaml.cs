using System;
using System.Collections.Generic;
using System.Drawing;
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
using static System.Reflection.Metadata.BlobBuilder;

namespace Practice_9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        List<Films> _movie = new List<Films>();

        private void Add(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(film.Text, out int FILM) & !int.TryParse(genre.Text, out int GENRE) & int.TryParse(year.Text, out int YEAR) & int.TryParse(duration.Text, out int DUR))
            {
                _movie.Add(new Films(film.Text, genre.Text, YEAR, DUR));
                structGrid.ItemsSource = null;
                structGrid.ItemsSource = _movie;
            }
            else MessageBox.Show("Ошибка");
        }

        private void AboutProgramm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заполнить таблицу фильмотеки на 7 кассет с полями: фильм, жанр, год выпуска, \r\nпродолжительность просмотра. Вывести результат на экран. Вывести список \r\nфильмов заданного жанра");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Genre(object sender, RoutedEventArgs e)
        {
            var foundFilms = new StringBuilder();

            foreach (var item in _movie)
            {
                if (item.Genre == Janre.Text)
                {
                    foundFilms.AppendLine(item.Film);
                }
            }
            MessageBox.Show(foundFilms.ToString());
        }
    }
}

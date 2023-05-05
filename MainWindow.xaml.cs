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

namespace bekende_trios
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b_harrypotter_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = "Harry";
            tb2.Text = "Hermione";
            tb3.Text = "Ron";
        }

        private void b_starwars_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = "Luke";
            tb2.Text = "Leia";
            tb3.Text = "Han";
        }

        private void b_ducktales_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = "Kwik";
            tb2.Text = "Kwek";
            tb3.Text = "Kwak";

        }
    }
}

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
using Capitulo_6_7.Capitulo_6;
using Capitulo_6_7.Capitulo_7;

namespace Capitulo_6_7
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

        
        private void Ejercicios_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_1 ejercicios = new Ejercicio_1();
            ejercicios.Show();
        }

        private void Ejercicio_1_Click(object sender, RoutedEventArgs e)
        {
            Program_1 ejercicio_1 = new Program_1();
            ejercicio_1.Show();
        }

        private void Ejercicio_2_Click(object sender, RoutedEventArgs e)
        {
            Program_2 ejercicio_2 = new Program_2();
            ejercicio_2.Show();
        }
        private void Ejercicio_5_Click(object sender, RoutedEventArgs e)
        {
            Program_5 ejercicio_1 = new Program_5();
            ejercicio_1.Show();
        }
    }
}

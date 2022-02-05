using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace Capitulo_6_7.Capitulo_7
{
    /// <summary>
    /// Interaction logic for Ejercicio1cap7.xaml
    /// </summary>

    /*---- 
     
        calcula el promedio, calificación máxima y mínima de un salón de clases usando el ArrayList 
        
    ----*/
    public partial class Program_1 : Window
    {
        private List <double> lista = new List<double>();
        public Program_1()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            lista.Add(double.Parse(calificaciontextBox.Text));
            calificaciontextBox.Text = " ";
        }

        private void Calcularbutton_Click(object sender, RoutedEventArgs e)
        {
            calcular();
        }


        private void calcular()
        {
            double suma = 0.0f, promedio = 0.0f, minima = 0.0f, maxima = 0.0f;

            for (int i = 0; i < lista.Count; i++)
            {
                minima = lista[0];
                suma = suma + lista[i];

                maxima = lista.Max();
                maximaTextBox.Text = maxima.ToString();

            }

            minima = lista.Min();
            minimaTextBox.Text = minima.ToString();

            promedio = suma / lista.Count;

            promedioTextBox.Text = promedio.ToString();
        }
    }
}
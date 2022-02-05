using System;
using System.Linq;
using System.Windows;

namespace Capitulo_6_7.Capitulo_6
{
    /// <summary>
    /// Interaction logic for Ejercicio_1.xaml
    /// </summary>

    /*---- 
    
        En este apartado calcula el promedio, la calificacion maxima y minima 
    
    ----*/

    public partial class Ejercicio_1 : Window
    {
        private static int LIMITE = 1000;
        private double [] nota = new double [LIMITE];
        private int cantidad = 0;
        public Ejercicio_1()
        {
            InitializeComponent();
        }
        private void agregarButton(object datos, RoutedEventArgs e)
        {
            Notas(nota);
        }

        private void calcularButton(object calculo, RoutedEventArgs e)
        {
            calculos();
        }

        private void Notas(double [] nota)
        {
            if (cantidad < LIMITE)
            {

                nota[cantidad] = Convert.ToInt32(calificacionTextBox.Text);
                calificacionTextBox.Text = " ";
                cantidad++;

            }
        }

        private void calculos()
        {
            double sumas = 0, maxima = 0, minima = 0, promedio = 0.0f;
            maxima = minima = nota[0];

            for (int i = 0; i < nota.Length; i++)
            {
                sumas += nota[i];

                promedio = sumas / i;

                if (nota[i] > maxima)
                {
                    maxima = nota[i];
                    mayorTextBox.Text = maxima.ToString(); 
                }

            }
            
            maxima = minima;
            minima = nota.Min();
            menorTextBox.Text = maxima.ToString();
            promedioTextBox.Text = promedio.ToString();

        }
    }
}

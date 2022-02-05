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
    /// Interaction logic for Ejercicio5Cap7.xaml
    /// </summary>
    public partial class Program_5 : Window
    {
        Hashtable Lista = new Hashtable();
        public Program_5()
        {
            InitializeComponent();
        }

        private void guardarButton_Click(object sender, RoutedEventArgs e)
        {
            Lista.Add(Convert.ToInt32(telefonoTextBox.Text), nombretextBox.Text);
            telefonoTextBox.Text = " ";
            nombretextBox.Text = " ";

            pantalla_2.Items.Clear();

            foreach(DictionaryEntry valor in Lista){
                pantalla_2.Items.Add("palabra: "+valor.Key);
                pantalla_2.Items.Add("descripcion: "+valor.Value);
            } 
        }
    }
}
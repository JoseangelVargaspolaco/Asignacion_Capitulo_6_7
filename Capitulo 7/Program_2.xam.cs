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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>

    /*---- 
    
        Este programa que funciona como un diccionario, con palabra y definición 
        
    ----*/
    public partial class Program_2 : Window
    {
        Hashtable Lista = new Hashtable();
        public Program_2()
        {
            InitializeComponent();
        }
        private void guardarButton_Click(object sender, RoutedEventArgs e)
        {
            Lista.Add(palabraTextBox.Text, DefiniciontextBox.Text);
            pantalla.Items.Add(Lista);
            pantalla.Items.Clear();

            foreach(DictionaryEntry valor in Lista){
                pantalla.Items.Add("palabra: "+valor.Key);
                pantalla.Items.Add("descripcion: "+valor.Value);
            }
        }

       
    }
}

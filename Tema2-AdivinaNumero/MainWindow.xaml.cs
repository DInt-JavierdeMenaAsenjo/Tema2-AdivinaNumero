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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numeroAleatorio;
        public MainWindow()
        {
            InitializeComponent();
            numeroAleatorio = generaNumero();
            prueba.Text = numeroAleatorio.ToString();
        }

        public int generaNumero()
        {
            Random rnd = new Random();
            return rnd.Next(101);
        }

        private void botonComprobar_Click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(numeroTextBox.Text) < numeroAleatorio)
            {
                pistaTextBlock.Text = "Te has quedado corto";
            }else if(int.Parse(numeroTextBox.Text) > numeroAleatorio)
            {
                pistaTextBlock.Text = "Te has pasado";
            }else
            {
                pistaTextBlock.Text = "ACERTASTE!";
            }
        }

        private void botonReiniciar_Click(object sender, RoutedEventArgs e)
        {
            numeroAleatorio = generaNumero();
            pistaTextBlock.Text = "";
            prueba.Text = numeroAleatorio.ToString();
        }
    }
}

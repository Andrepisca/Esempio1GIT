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

namespace _08_10_2022
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //bottone che calcola la media
        private void btnMedia_Click(object sender, RoutedEventArgs e)
        {
            double[] v = new double[10];
            Random rnd = new Random();
            //ciclo per caricare il vettoredi numeri casuali
            for(int i = 0; i < 10; i++)
                v[i] = rnd.Next(0,100);
           
            double somma =0;
            //calcolo media
            for (int i = 0; i < 10; i++)
                somma += v[i];

            lblOutput.Content = somma / 10;

        }
    }
}

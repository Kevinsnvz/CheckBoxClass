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

namespace clase4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            List<ciudades> ListaCiudades = new List<ciudades>();
            ListaCiudades.Add(new ciudades()
            {
                nombre = "estanbul"

            }); ;
            ListaCiudades.Add(new ciudades()
            {
                nombre = "rio du janeiro"

            }); ;
            ListaCiudades.Add(new ciudades()
            {
                nombre = "pisos picados"

            }); ;
            ComboBoxCiudades.ItemsSource = ListaCiudades;

            
            

        }

        private void AllCheck_Checked(object sender, RoutedEventArgs e)
        {
            
            
            if (TodosCheck.IsChecked == true)
            {
                uruguayCheck.IsChecked = true;
                usaCheck.IsChecked = true;
                brasilCheck.IsChecked = true;
            }
            
        }

        private void OptionCheck_Click(object sender, RoutedEventArgs e)
        {
            if (uruguayCheck?.IsChecked == true && usaCheck?.IsChecked == true && brasilCheck?.IsChecked == true)
            {
                TodosCheck.IsChecked = true;
            }
            else if (uruguayCheck?.IsChecked == true || usaCheck?.IsChecked == true || brasilCheck?.IsChecked == true 
                  || uruguayCheck?.IsChecked == null || usaCheck?.IsChecked == null || brasilCheck?.IsChecked == null)
            {
                TodosCheck.IsChecked = null;
            }
            else
            {
                TodosCheck.IsChecked = false;
            }

             
            
        }
    }
}

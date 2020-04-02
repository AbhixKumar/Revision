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
using PizzaBox.Domain.Models;
using PizzaBox.Storage.Repositories;

namespace Pizzabox.WPFTesting
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

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            PizzaRepository pz = new PizzaRepository();
            //Pizza pizza = new Pizza();    
            CrustRepository cz = new CrustRepository();

            foreach(Crust pizza in cz.GetCrusts())
            {
                lstCombo.Items.Add(pizza.Name);
            }
        }

        private void txtTest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

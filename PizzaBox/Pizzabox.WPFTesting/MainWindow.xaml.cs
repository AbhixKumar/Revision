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
            
            var add = pz.GetPizzas();
            lstCombo.Items.Add(add);

            CrustRepository cz = new CrustRepository();
            int tryid = 5;
            var addc = cz.GetACrust(tryid);

            txtTest.Text = addc.Name;


        }

        private void txtTest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

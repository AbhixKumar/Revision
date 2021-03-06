﻿using System;
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
            LoadAll();
            LoadStore();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            StoreRepository stz = new StoreRepository();
            Store store1 = new Store();
            string mess1 = store1.StoreLocation;

            txtLocation.Text = stz.GetStoreName(mess1).ToString();
        }
     
        private void lstCombo_Loaded(object sender, RoutedEventArgs e)
        {
         
        }

        public void LoadAll()
        {
            PizzaRepository pz = new PizzaRepository();
            SizeRepository sz = new SizeRepository();
            CrustRepository cz = new CrustRepository();
                      
            foreach (var size in sz.GetAllSizes())
            {
                lstCombo.Items.Add(size.Name);                   
            }  

            foreach (var crust in cz.GetCrusts())
            {
                lstCrust.Items.Add(crust.Name);
            }         
        }

        public void LoadStore()
        {

        }
        private void lstCrust_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

      
    }
}

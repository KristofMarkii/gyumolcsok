using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public class Gyumolcs
        {
            public int Azonosito { get; set; }
            public string Nev { get; set; }
            public double Ertek1 { get; set; } 
            public double Ertek2 { get; set; } 
            public Gyumolcs(string sor)
            {
                string[] t = sor.Split(',');
                Azonosito = Convert.ToInt32(t[0]);
                Nev = t[1];
                Ertek1 = double.Parse(t[2]);
                Ertek2 = double.Parse(t[3]);
            }
        }

        List<Gyumolcs> gyumolcsok = new List<Gyumolcs>();

        public MainWindow()
        {
            InitializeComponent();
            FajlBetoltes();
        }

        private void FajlBetoltes()
        {
            foreach (var sor in File.ReadAllLines("gyumolcsok.txt"))
            {
                gyumolcsok.Add(new Gyumolcs(sor));
            }
        }

        private void betoltes_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            foreach (var i in gyumolcsok)
            {
                lista.Items.Add($"{i.Azonosito}: {i.Nev} - db: {i.Ertek1}, kilógrammos ára: {i.Ertek2} FT/kg");
            }
        }

        private void atlag_Click(object sender, RoutedEventArgs e)
        {
            double atlagErtek1 = gyumolcsok.Average(g => g.Ertek1);
            double atlagErtek2 = gyumolcsok.Average(g => g.Ertek2);
            eredmenyTextBlock.Text = $"Átlagos mennyiség: {atlagErtek1:F2} db\nÁtlagos ár: {atlagErtek2:F2} FT/kg";
        }

        private void osszeg_Click(object sender, RoutedEventArgs e)
        {
            double osszegErtek1 = gyumolcsok.Sum(g => g.Ertek1);
            double osszegErtek2 = gyumolcsok.Sum(g => g.Ertek2);
            eredmenyTextBlock.Text = $"Összes mennyiség: {osszegErtek1:F2} db\nÖsszes ár: {osszegErtek2:F2} FT/kg";
        }

        private void maximum_Click(object sender, RoutedEventArgs e)
        {
            double maxErtek1 = gyumolcsok.Max(g => g.Ertek1);
            double maxErtek2 = gyumolcsok.Max(g => g.Ertek2);
            eredmenyTextBlock.Text = $"Maximum mennyiség: {maxErtek1:F2} db\nMaximum ár: {maxErtek2:F2} FT/kg";
        }
    }
}
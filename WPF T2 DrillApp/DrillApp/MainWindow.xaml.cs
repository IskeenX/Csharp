using System.Collections.Generic;
using System.Windows;

namespace DrillApp
{
    public partial class MainWindow : Window
    {
        public Drill kimo = new Drill
        {
            Manufacturer = "KIMO.",
            PackageDimensions = "13.7 x 10.6 x 3 inches",
            ItemWeight = "2.84 pounds",
            PartNumber = "K13811",
            Material = Material.Titanium,
            Usage = new Usage { Concrete = true, Wood = true, Metal = true, HardBrick = true, HardMaterial = false, Screwdriver = true },
            Size = "Medium",
            PowerSource = "Battery Powered",
            IncludeComponents = new List<string>() { "1xKIMO Cordless K13811 Drill Driver", "1x2.0Ah 20V Lithium-Ion Battery", "1xFast Charger" },
            Speed = Speed.Medium,
            Torque = "350 Inch Pounds",
            InstallationMethod = "Screw-In",
            Note = "Average Battery Life 1000 Hours"
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void applyBttn_Click(object sender, RoutedEventArgs e)
        {
            myBorder.DataContext = kimo;
        }

        private void resetBttn_Click(object sender, RoutedEventArgs e)
        {
            myBorder.DataContext = null;
        }
    }
}
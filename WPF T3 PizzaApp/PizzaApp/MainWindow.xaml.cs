using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PizzaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double fullPrice = 0.0;
        ObservableCollection<Ordering> orderings = new ObservableCollection<Ordering>();
        List<Pizzas> pizzas = new List<Pizzas>()
        {
            new Pizzas(){ Name="SonGoKu", Price=8.1 },
            new Pizzas(){ Name="Onion", Price=7.9 },
            new Pizzas(){ Name="Chiese", Price=6.8 },
            new Pizzas(){ Name="Fishy", Price=10.1 },
        };
        public MainWindow()
        {
            InitializeComponent();
            cmb.ItemsSource = pizzas;
            lbx.ItemsSource = orderings;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cmb.SelectedItem != null)
            {
                orderings.Add(new Ordering() { Name = cmb.Text, Price = (double)cmb.SelectedValue, IsGlutenfree = (chcGluten.IsChecked == true ? true : false)});
                cmb.SelectedIndex = -1;
                chcGluten.IsChecked = false;
            }
        }
    }
}
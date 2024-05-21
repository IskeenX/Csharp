using System.Collections.Generic;
using System.Windows;

namespace PersonApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bttnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {txtBxFirstName.Text} {txtBxLastName.Text}");
        }
    }
}
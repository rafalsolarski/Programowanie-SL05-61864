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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Cyfra1;
        double Cyfra2;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cyfra1 = Convert.ToDouble(textbox2_Copy.Text);
            Cyfra2 = Convert.ToDouble(textbox2.Text);
            labelwynik.Content = Cyfra1 + Cyfra2;
        }

        private void roznica_Click(object sender, RoutedEventArgs e)
        {
            Cyfra1 = Convert.ToDouble(textbox2_Copy.Text);
            Cyfra2 = Convert.ToDouble(textbox2.Text);
            labelwynik.Content = Cyfra1 - Cyfra2;
        }

        private void mnozenie_Click(object sender, RoutedEventArgs e)
        {
            Cyfra1 = Convert.ToDouble(textbox2_Copy.Text);
            Cyfra2 = Convert.ToDouble(textbox2.Text);
            labelwynik.Content = Cyfra1 * Cyfra2;
        }

        private void dzielenie_Click(object sender, RoutedEventArgs e)
        {
            Cyfra1 = Convert.ToDouble(textbox2_Copy.Text);
            Cyfra2 = Convert.ToDouble(textbox2.Text);
            if (Cyfra2 == 0)
            {
                MessageBox.Show("Nie dziel przez 0", "UWAGA");
            }
            else
                labelwynik.Content = Cyfra1 / Cyfra2;
        }
    }
}

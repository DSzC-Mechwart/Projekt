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

namespace KretaNaplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Nevek = new List<string>();

        private int clickedTimes;

        private string name = "";
        public MainWindow()
        {
            InitializeComponent();

            clickedTimes = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = input.Text;

            NameLabel.Content = $"Hozzáadva: {name.ToString()}";

            Nevek.Add(name);

            Lista.Items.Add(name);
            
            input.Clear();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Lista.Visibility == Visibility.Visible) 
            {
                Lista.Visibility=Visibility.Hidden;
                Gomb2.Content = ("Megjelenít");
            }
            else
            {
                Lista.Visibility=Visibility.Visible;
                Gomb2.Content = ("Eltűntet");
            }
        }

        private void Gomb3_Click(object sender, RoutedEventArgs e)
        {
            Lista.Items.Clear();
            NameLabel.Content = ("");
        }

        private void bej2_Click(object sender, RoutedEventArgs e)
        {
            if (bej1.Text == "Mark")
            {
                bej1.Visibility=Visibility.Hidden;
                bej2.Visibility = Visibility.Hidden;
                bej3.Visibility = Visibility.Hidden;
                
                NameLabel.Visibility = Visibility.Visible;
                
                Lista.Visibility = Visibility.Visible;
            }
            else 
            {
                MessageBox.Show("Hibás felhasználónév!");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Gomb1.Visibility == Visibility.Visible) 
            {
                Gomb1.Visibility = Visibility.Hidden;
                Gomb2.Visibility = Visibility.Hidden;
                Gomb3.Visibility = Visibility.Hidden;
                input.Visibility = Visibility.Hidden;
            }
            else
            {
                Gomb1.Visibility = Visibility.Visible;
                Gomb2.Visibility = Visibility.Visible;
                Gomb3.Visibility = Visibility.Visible;
                input.Visibility = Visibility.Visible;
            }
        }
    }
}

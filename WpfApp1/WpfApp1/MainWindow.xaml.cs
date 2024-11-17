using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rnd = new Random();
        string[] colors = { "rood", "geel", "oranje", "blauw", "wit", "groen" };
        List<string> tittleCheck = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                tittleCheck.Add(colors[rnd.Next(0, 6)]);
            }
            string combinedString = string.Join(",", tittleCheck.ToArray());
            this.Title = combinedString;
        }

        private void codeCheck_Click(object sender, RoutedEventArgs e)
        {
            
            ComboBoxItem selectedItem1 = comboBox1.SelectedItem as ComboBoxItem;
            string selectedColor1 = selectedItem1?.Content.ToString().Trim();

            ComboBoxItem selectedItem2 = comboBox2.SelectedItem as ComboBoxItem;
            string selectedColor2 = selectedItem2?.Content.ToString().Trim();

            
            ComboBoxItem selectedItem3 = comboBox3.SelectedItem as ComboBoxItem;
            string selectedColor3 = selectedItem3?.Content.ToString().Trim();

            ComboBoxItem selectedItem4 = comboBox4.SelectedItem as ComboBoxItem;
            string selectedColor4 = selectedItem4?.Content.ToString().Trim();

            
            if (selectedColor1 == tittleCheck[0])
            {
                colorLabel1.BorderBrush = new SolidColorBrush(Colors.Green);
                colorLabel1.BorderThickness = new Thickness(3);
            }
            else
            {
                colorLabel1.BorderBrush = new SolidColorBrush(Colors.Red);
                colorLabel1.BorderThickness = new Thickness(3);
            }

            if (selectedColor2 == tittleCheck[1])
            {
                colorLabel2.BorderBrush = new SolidColorBrush(Colors.Green);
                colorLabel2.BorderThickness = new Thickness(3);
            }
            else
            {
                colorLabel2.BorderBrush = new SolidColorBrush(Colors.Red);
                colorLabel2.BorderThickness = new Thickness(3);
            }

            if (selectedColor3 == tittleCheck[2])
            {
                colorLabel3.BorderBrush = new SolidColorBrush(Colors.Green);
                colorLabel3.BorderThickness = new Thickness(3);
            }
            else
            {
                colorLabel3.BorderBrush = new SolidColorBrush(Colors.Red);
                colorLabel3.BorderThickness = new Thickness(3);
            }

            if (selectedColor4 == tittleCheck[3])
            {
                colorLabel4.BorderBrush = new SolidColorBrush(Colors.Green);
                colorLabel4.BorderThickness = new Thickness(3);
            }
            else
            {
                colorLabel4.BorderBrush = new SolidColorBrush(Colors.Red);
                colorLabel4.BorderThickness = new Thickness(3);
            }
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;          
                ComboBoxItem item = box.SelectedItem as ComboBoxItem;
                switch (item.Content.ToString().Trim())
                {
                    case "wit":
                        colorLabel1.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "groen":
                        colorLabel1.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "blauw":
                        colorLabel1.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "rood":
                        colorLabel1.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "geel":
                        colorLabel1.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "oranje":
                        colorLabel1.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            ComboBoxItem item = box.SelectedItem as ComboBoxItem;
            switch (item.Content.ToString().Trim())
            {
                case "wit":
                    colorLabel2.Background = new SolidColorBrush(Colors.White);
                    break;
                case "groen":
                    colorLabel2.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "blauw":
                    colorLabel2.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "rood":
                    colorLabel2.Background = new SolidColorBrush(Colors.Red);
                    break;
                case "geel":
                    colorLabel2.Background = new SolidColorBrush(Colors.Yellow);
                    break;
                case "oranje":
                    colorLabel2.Background = new SolidColorBrush(Colors.Orange);
                    break;
                default:

                    break;
            }
        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            ComboBoxItem item = box.SelectedItem as ComboBoxItem;
            switch (item.Content.ToString().Trim())
            {
                case "wit":
                    colorLabel3.Background = new SolidColorBrush(Colors.White);
                    break;
                case "groen":
                    colorLabel3.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "blauw":
                    colorLabel3.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "rood":
                    colorLabel3.Background = new SolidColorBrush(Colors.Red);
                    break;
                case "geel":
                    colorLabel3.Background = new SolidColorBrush(Colors.Yellow);
                    break;
                case "oranje":
                    colorLabel3.Background = new SolidColorBrush(Colors.Orange);
                    break;
                default:

                    break;
            }
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            ComboBoxItem item = box.SelectedItem as ComboBoxItem;
            switch (item.Content.ToString().Trim())
            {
                case "wit":
                    colorLabel4.Background = new SolidColorBrush(Colors.White);
                    break;
                case "groen":
                    colorLabel4.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "blauw":
                    colorLabel4.Background = new SolidColorBrush(Colors.Blue);
                    break;
                case "rood":
                    colorLabel4.Background = new SolidColorBrush(Colors.Red);
                    break;
                case "geel":
                    colorLabel4.Background = new SolidColorBrush(Colors.Yellow);
                    break;
                case "oranje":
                    colorLabel4.Background = new SolidColorBrush(Colors.Orange);
                    break;
                default:

                    break;
            }
        }
    }
}
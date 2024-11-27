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
using System.Windows.Threading;
using System.Xml.Serialization;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rnd = new Random();
        string[] colors = { "rood", "geel", "oranje", "blauw", "wit", "groen" };
        string[] tittleCheck = new string[4];
        private DispatcherTimer timer = new DispatcherTimer();
        int timerTick = 0;
        int attempt = 0;

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            for (int i = 0; i < 4; i++)
            {
                tittleCheck[i] += colors[rnd.Next(0, 6)];
            }
            string combinedString = string.Join(",", tittleCheck);
            codeBlock.Text = combinedString;

            this.KeyDown += toggleDebug;
        }

        private void addAtempt()
        {
            attempt++;
            this.Title = attempt.ToString();
        }

        private void toggleDebug(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) && e.Key == Key.F12)
            {
                codeBlock.Visibility = Visibility.Visible;
            }
        }
        
        private void codeCheck_Click(object sender, RoutedEventArgs e)
        {
            addAtempt();
            StopCountDown();
            StartCountDown();

            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4 };
            Label[] colorLabels = { colorLabel1, colorLabel2, colorLabel3, colorLabel4 };

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                ComboBox comboBox = comboBoxes[i];
                Label colorLabel = colorLabels[i];

                ComboBoxItem selectedItem = comboBox.SelectedItem as ComboBoxItem;
                

                if (selectedItem != null)
                {
                    string selectedColor = selectedItem.Content.ToString().Trim();
                    if (selectedColor == tittleCheck[i])
                    {
                        colorLabel.BorderBrush = new SolidColorBrush(Colors.Wheat);
                        colorLabel.BorderThickness = new Thickness(3);
                    }
                    else
                    {
                        colorLabel.BorderBrush = new SolidColorBrush(Colors.Red);
                        colorLabel.BorderThickness = new Thickness(3);
                    }
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timerTick++;
            timerBlock.Text = timerTick.ToString();


            if (timerTick == 10)
            {
                attempt++;
                StopCountDown();
            }
        }
        private void StartCountDown()
        {
            timerTick = 0;
            timer.Start();
        }
        private void StopCountDown()
        {
            timer.Stop();
            timerTick = 0;            
            this.Title = attempt.ToString();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4 };
            Label[] colorLabels = { colorLabel1, colorLabel2, colorLabel3, colorLabel4 };
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                ComboBox comboBox = comboBoxes[i];
                Label colorLabel = colorLabels[i];

                ComboBoxItem item = comboBox.SelectedItem as ComboBoxItem;
                if (item != null)  
                {
                    string selectedColor = item.Content.ToString().Trim();

                    switch (selectedColor)
                    {
                        case "wit":
                            colorLabel.Background = new SolidColorBrush(Colors.White);
                            break;
                        case "groen":
                            colorLabel.Background = new SolidColorBrush(Colors.Green);
                            break;
                        case "blauw":
                            colorLabel.Background = new SolidColorBrush(Colors.Blue);
                            break;
                        case "rood":
                            colorLabel.Background = new SolidColorBrush(Colors.Red);
                            break;
                        case "geel":
                            colorLabel.Background = new SolidColorBrush(Colors.Yellow);
                            break;
                        case "oranje":
                            colorLabel.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        default:
                            colorLabel.Background = null;  
                            break;
                    }
                }
            }
        }
    }
}
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Git_Taak_1_BORNA_HAJAROLASAWADI
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

        private void redButton_Click(object sender, RoutedEventArgs e)
        {
            colorCodeTextBox.Text = "#FF0000";
            informationTextBox.Text = "Rood is de kleur van warmte";
        }

        private void yellowButton_Click(object sender, RoutedEventArgs e)
        {
            colorCodeTextBox.Text = "#FFFF00";
            informationTextBox.Text = "Geel is de kleur van levenslust";
        }

        private void greenButton_Click(object sender, RoutedEventArgs e)
        {
            colorCodeTextBox.Text = "#008000";
            informationTextBox.Text = "Groen is de kleur van genezing";
        }

        private void blueButton_Click(object sender, RoutedEventArgs e)
        {
            colorCodeTextBox.Text = " #0000FF";
            informationTextBox.Text = "Blauw is de kleur van intelligentie";
        }

        private void redButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }

        private void redButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Console.ResetColor();
        }

        private void yellowButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        private void yellowButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Console.ResetColor();
        }

        private void greenButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }

        private void greenButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Console.ResetColor();
        }

        private void blueButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }

        private void blueButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Console.ResetColor();
        }

    }
}
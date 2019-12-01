using System;
using System.Collections.Generic;
using System.IO;
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

namespace Seat_Assigner
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

        private void CBname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LBoutput.Items.Add(CBname.SelectedItem);
        }

        private void BTNName_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines("StudentNames.txt");

            foreach (var line in lines)
            {
                string[] l = line.Split(':');
                CBname.Items.Add(l[0] + " " + l[1]);
            }
        }
        
        //Returns number less than 50 
        //int num = random.Next(50);
        public int RandomNumber(int min, int max)
        {
            Random rand = new Random();
            return random.Next(min, max);
        }

        public class RandomGenerator
        {
        //Generate a random number between two numbers
            public int RandomNumber(int min, int max)
            {
                Random rand = new Random();
                return random.Next(min, max);
            }
        }

        private void LBoutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LBoutput.Items.Add($"lName", "fName", "id");
        }
        
    }
}

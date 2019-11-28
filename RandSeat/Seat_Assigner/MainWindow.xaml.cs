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

        private void LBoutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}

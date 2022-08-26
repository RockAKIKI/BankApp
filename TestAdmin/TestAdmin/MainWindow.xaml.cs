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

namespace TestAdmin
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

        string Admin = "Rock Akiki";
        string Pass = "DGFDGF123@";

        private void ValidateButton_Click(object sender, RoutedEventArgs e)
        {
            if (Identifiant.Text == Admin && Password.Text == Pass)
            {
                TestBox.Text = "Access permitted";
            }
            else
            {
                TestBox.Text = "Warning u are Not Rock; access restricted; contacting police";
                
                TestBox.Width += 0.5*TestBox.Width;
            }
        }
    }
}

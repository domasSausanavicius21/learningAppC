using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Debug.WriteLine("some info!");
        }

        private void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Button clicked!");

            TitleLabel.Content = "Changed title!";
        }

        private void HandleMouseMovement(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Mouse moved: " + e.GetPosition(this).X);
        }
    }
}

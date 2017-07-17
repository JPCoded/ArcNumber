using System;
using System.Windows;

namespace ArcNumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            acSegment.SetArc(0);
        }

        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
            acSegment.IncreaseArc();
        }
    }
}

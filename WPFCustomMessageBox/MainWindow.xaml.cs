using System.Windows;

namespace WPFCustomMessageBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Custom WPF Message Box", "Shade#0122", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.Yes,"Shade#0122");
            }
            else
            {
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.No, "Shade#0122");
            }
            return;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Custom WPF Message Box", "Shade#0122", MessageBoxButton.OK) == MessageBoxResult.OK)
            {
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.OK, "Shade#0122");
            }
            return;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Custom WPF Message Box", "Shade#0122", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.OK, "Shade#0122");
            }
            else
            {
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.Cancel, "Shade#0122");
            }
            return;
        }
    }
}

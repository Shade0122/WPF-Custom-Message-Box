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
            if (MessageBox.Show("Title", "Message", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.Yes);
            else
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.No);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Title", "Message", MessageBoxButton.OK) == MessageBoxResult.OK)
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.OK);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Title", "Message", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.OK);
            else
                System.Windows.MessageBox.Show("Pressed: " + MessageBoxResult.Cancel);
        }
    }
}

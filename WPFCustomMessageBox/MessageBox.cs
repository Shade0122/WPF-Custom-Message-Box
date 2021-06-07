using System.Windows;

namespace WPFCustomMessageBox
{
    public partial class MessageBox
    {
        static MessageBox _messageBox;
        static MessageBoxResult _result = MessageBoxResult.No;
        public static MessageBoxResult Show

        (string caption, string text, MessageBoxButton button)
        {
            return Show(caption, text, button, MessageBoxImage.None);
        }

        public static MessageBoxResult Show(string caption, string text, MessageBoxButton button, MessageBoxImage image)
        {
            _messageBox = new MessageBox{txtMsg = { Text = text }, MessageTitle = { Text = caption }};
            SetVisibilityOfButtons(button);
            _messageBox.ShowDialog();
            return _result;
        }

        private static void SetVisibilityOfButtons(MessageBoxButton button)
        {
            switch (button)
            {
                case MessageBoxButton.OK:
                    _messageBox.ButtonCancel.Visibility = Visibility.Collapsed;
                    _messageBox.ButtonNo.Visibility = Visibility.Collapsed;
                    _messageBox.ButtonYes.Visibility = Visibility.Collapsed;
                    _messageBox.ButtonOk.Focus();
                    break;
                case MessageBoxButton.OKCancel:
                    _messageBox.ButtonNo.Visibility = Visibility.Collapsed;
                    _messageBox.ButtonYes.Visibility = Visibility.Collapsed;
                    _messageBox.ButtonCancel.Focus();
                    break;
                case MessageBoxButton.YesNo:
                    _messageBox.ButtonOk.Visibility = Visibility.Collapsed;
                    _messageBox.ButtonCancel.Visibility = Visibility.Collapsed;
                    _messageBox.ButtonNo.Focus();
                    break;
                default:
                    break;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == ButtonOk)
                _result = MessageBoxResult.OK;
            else if (sender == ButtonYes)
                _result = MessageBoxResult.Yes;
            else if (sender == ButtonNo)
                _result = MessageBoxResult.No;
            else if (sender == ButtonCancel)
                _result = MessageBoxResult.Cancel;
            else
                _result = MessageBoxResult.None;
            _messageBox.Close();
            _messageBox = null;
        }
    }
}
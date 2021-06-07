using System;
using System.Windows;

namespace WPFCustomMessageBox
{
    public partial class MessageBox : Window
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        public enum MessageBoxType
        {
            Confirmation,
            Information,
            Error,
            Warning
        }

        public enum MessageBoxImage
        {
            Warning,
            Question,
            Information,
            Error,
            None
        }

        internal static object Show(string v1, string v2, MessageBoxButton yesNo, System.Windows.MessageBoxImage warning)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EvmPracticum_2_05
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

        private void tblogin_LostFocus(object sender, RoutedEventArgs e)
        {
            LostFocusHandler(tblogin);
        }
        
        private void pbpass_LostFocus(object sender, RoutedEventArgs e)
        {
            LostFocusHandler(pbpass);
        }
        private void pbpass2_LostFocus(object sender, RoutedEventArgs e)
        {
            LostFocusHandler(pbpass2);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if ((tblogin.Text.Length > 0) &&
                (pbpass.Password.Length > 0) &&
                (pbpass2.Password == pbpass.Password)){
                MessageBox.Show("Регистрация прошла успешно");
            }
            else
            {
                MessageBox.Show("Регистрация не прошла");
            }
        }
        private void LostFocusHandler(Control control)
        {
            if (IsControlEmpty(control))
            {
                control.BorderBrush = Brushes.Red;
                control.BorderThickness = new Thickness(3.0);
            }
            else
            {
                control.BorderBrush = Brushes.Gray;
                control.BorderThickness = new Thickness(0, 0, 0, 1);
            }
        }
        private bool IsControlEmpty(Control control)
        {
            if (control is TextBox)
            {
                return string.IsNullOrEmpty(((TextBox)control).Text);
            }
            else if (control is PasswordBox)
            {
                return string.IsNullOrEmpty(((PasswordBox)control).Password);
            }

            return false;
        }
    }
}

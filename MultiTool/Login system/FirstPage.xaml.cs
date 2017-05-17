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
using System.Windows.Shapes;

namespace MultiTool.Login_system {
    /// <summary>
    /// Interaction logic for FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Window {
        public FirstPage() {
            InitializeComponent();
        }

        private void MenuLogin(object sender, RoutedEventArgs e) {
            var s = new MultiTool.Unit_Converter.UnitConverter();
            s.Show();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e) {
            var password = PasswordBox.Password;
        }

    }
}

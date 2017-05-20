using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FirstPage : Window, INotifyPropertyChanged {
        public FirstPage() {
            InitializeComponent();
            this.DataContext = this;
        }

        #region NotifyProperties
        public String Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        #endregion
        #region PropertyChangedNotifier
        protected virtual void OnPropertyChanged(string name) {
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        private String username;
        private String password;
        private String userAdmin = "admin";
        private String passAdmin = "admin";

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e) {
            this.password = PasswordBox.Password.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if(username == userAdmin && password == passAdmin) {
                var s = new MultiTool.Unit_Converter.UnitConverter();
                s.Show();
            }else {
                MessageBoxResult result = MessageBox.Show("User and/or password invalid. Press 'Yes' to exit now or 'No' to try again.", "Invalid login", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if(result == MessageBoxResult.Yes) {
                    Application.Current.Shutdown();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {

        }
    }
}

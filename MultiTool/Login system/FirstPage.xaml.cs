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
        private string username;
        private string password;

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

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e) {
            this.password = PasswordBox.Password.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            User myUser = new User(username, password);

            if(username == "admin" && password == "admin") {
                var s = new MultiTool.Unit_Converter.UnitConverter();
                s.Show();
                this.Close();

            }else{
                MessageBoxResult result = MessageBox.Show("User and/or password invalid.Press 'Yes' to exit now or 'No' to try again.", "Invalid login", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if(result == MessageBoxResult.Yes) Application.Current.Shutdown();
            }
        }



    }
}

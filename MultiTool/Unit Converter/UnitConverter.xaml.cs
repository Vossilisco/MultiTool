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

namespace MultiTool.Unit_Converter {
    /// <summary>
    /// Interaction logic for UnitConverter.xaml
    /// </summary>
    public partial class UnitConverter : Window, System.ComponentModel.INotifyPropertyChanged {
        public UnitConverter() {
        InitializeComponent();
        this.DataContext = this;
    }

    #region NotifyProperties
    private double _kilometros;
    private double _metros;
    public double Kilometros
    {
        get { return _kilometros; }
        set
        {
            if(value != _kilometros)
                _kilometros = value;
            OnPropertyChanged("Kilometros");
        }
    }


    public double Metros
    {
        get { return _metros; }
        set
        {
            if(value != _metros) {
                _metros = value;
                OnPropertyChanged("Metros");
            }
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

    void Convert_Click(object sender, RoutedEventArgs e) {
        if(Math.Abs(Metros) != 0) {
            Kilometros = Metros * 3.6;
        }
        if(Math.Abs(Kilometros) != 0) {
            Metros = Kilometros / 3.6;
        }
    }

    void Reset_Click(object sender, RoutedEventArgs e) {
        Metros = 0;
        Kilometros = 0;
    }


}
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.ComponentModel;

namespace EncodingPwd
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private CommonDependency mCommonDependency = new CommonDependency();
        public MainWindow()
        {
            InitializeComponent();

            UserBlock.DataContext = mCommonDependency;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public class CommonDependency : DependencyObject    //必须继承DependencyObject才能成为一个依赖对象!!!!!!
    {
        public string UserName
        {
            get { return (string)GetValue(VisualUserName); }
            set { SetValue(VisualUserName, value); }
        }
        public static readonly DependencyProperty VisualUserName =
            DependencyProperty.Register("UserName", typeof(string), typeof(CommonDependency), new PropertyMetadata("Guest"));
    }
}

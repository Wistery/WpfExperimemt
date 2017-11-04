using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EncodingPwd
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private static Object mSingleInstance = null;
        protected override void OnStartup(StartupEventArgs e)
        {
            if (mSingleInstance != null)
            {
                //Application.Current.MainWindow?.Activate();
                Application.Current.Shutdown();
                return;
            }
            else
            { 
                mSingleInstance = new Object();
                GC.KeepAlive(mSingleInstance);

                base.OnStartup(e);
            }
        }
    }

    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void Notify([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

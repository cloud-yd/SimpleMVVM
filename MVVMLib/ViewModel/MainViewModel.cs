using System.ComponentModel;
using System.Windows.Input;
using MVVMLib.Model;

namespace MVVMLib.ViewModel
{
    public class MainViewModel : NotifyPropertyChangedBase
    {
        private string myVar;

        public string MyProperty
        {
            get { return myVar; }
            set { myVar = value; MyPropertyChanged(nameof(MyProperty)); }
        }

        private readonly MainModel textShow = new MainModel();

        private void CommandHaHa()
        {
            MyProperty = textShow.HaHaShow();       
        }

        private void CommandHeiHei()
        {
            MyProperty = textShow.HeiHeiShow();
        }

        public ICommand HaHa => new Command(o => CommandHaHa());
        public ICommand HeiHei => new Command(o => CommandHeiHei());
    }
}

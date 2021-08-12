using System.ComponentModel;

namespace MVVMLib
{
    /// <summary>
    /// 通知属性更改的基类，ViewModel需要通知界面时，继承该类
    /// </summary>
    public class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged =(sender, e) =>{};

        /// <summary>
        /// 通知属性更改
        /// </summary>
        /// <param name="Proprety"></param>
        protected void MyPropertyChanged(string Proprety)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Proprety));
        }
    }
}

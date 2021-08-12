using System;
using System.Collections.Generic;
using System.Text;
using MVVMLib.ViewModel;

namespace LearnMVVM
{
    class ViewModelLocator
    {
        public MainViewModel MainViewModel => new MainViewModel();
    }
}

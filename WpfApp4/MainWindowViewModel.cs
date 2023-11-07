using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfApp4
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool optionEnabled;
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class MainWindowViewModel
    {
        private bool optionEnabled;
        public bool OptionEnable
        {
            get => optionEnabled;
            set
            {
                if (optionEnabled == value) return;

                optionEnabled = value;
                OptionEnableChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler OptionEnableChanged;
    }
}

using SimpleObjectWPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SimpleObjectWPF.ViewModels
{
    class WPFCalculator : INotifyPropertyChanged
    {
        Calculator calculator = new Calculator();
        public int value {
            get { return this.calculator.value; }
            set { this.calculator.value = value;
                OnPropertyChanged("calculate");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleObjectWPF.Models
{
    public interface ICalculate
    {
        int value { get; set; }
        void add(int valToAdd);
        void subtract(int valToSubtract);
    }
}
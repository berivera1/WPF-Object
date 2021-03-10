using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleObjectWPF.Models
{
    class Calculator : ICalculate
    {
        public int value { get; set; }
        public Calculator(int initVal = 0) {
            value = initVal;
        }
        public void add(int valToAdd = 1)
        {
            value += valToAdd;
        }
        public void subtract(int valToSubtract = 1)
        {
            value -= valToSubtract;
        }
    }
}

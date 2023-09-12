using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uninter_1
{
    internal class DivisorCalc : IDivisor
    {
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }
}

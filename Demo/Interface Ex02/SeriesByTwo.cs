using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex02
{
    internal class SeriesByTwo : ISeries
    {
        public int Current { get; set; } // 0

        public void Next()
        {
            Current += 2;
        }

        public void Reset()
        {

            Current = 0;
        }
            }

}


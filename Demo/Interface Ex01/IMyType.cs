using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex01
{
    internal interface IMyType
    {
       // What Can Write Inside The Interface:
      // 1. Signature Of Properties
      // 2. Signature Of Methods [Name, Parameter, Return Type]
      // 3. Default Implmented Methods [Fully Implemented Methods]

// 2. Signature Of Methods [Name, Parameter, Return Type]
void MyFun();

// 1. Signature Of Properties
double Salary { set; get; }

// 3. Default Implmented Methods [Fully Implemented Methods]
          void Print()
        {
            Console.WriteLine(value: "Default Implmented Methods [Fully Implemented Methods]");
        }
    }
}

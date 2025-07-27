using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex03
{

internal class Airplane : IMoveable, IFlyable
	{

		int IMoveable.Speed { get; set; }
        int IFlyable.Speed { get; set; }

        void IMoveable.Backward()
		{
			Console.WriteLine(value: "Airplane IMoveable Backward");
		}

		void IMoveable.Forward()
		{
			Console.WriteLine(value: "Airplane IMoveable Forward");
		}
		void IMoveable.Left()
		{
			Console.WriteLine(value: "Airplane IMoveable Left");
		}

		void IMoveable.Right()
		{
			Console.WriteLine(value: "Airplane IMoveable Right");
		}
	}

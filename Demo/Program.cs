using Demo.Interface_Ex01;
using Demo.Interface_Ex02;
using Demo.Interface_Ex03;
using System.Text;
using System.Xml.Linq;

namespace Demo
{
    // 1. class
    // 2. struct
    // 3. enum
    // 4. interface
    internal class Program
    {
        static void Print10Number(SeriesByTwo series)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.Write(value: $"{series.Current}");
                series.Next();
            }

            Console.WriteLine();
            series.Reset();
        }
        static void Print10Number(SeriesByThree series)

        {
            for (int i = 0; i < 10; i++)
            {

                Console.Write(value: $"{series.Current}");
                series.Next();
            }
            Console.WriteLine();
            series.Reset();

        }

        static void Print10Number(SeriesByFour series)
        {

            for (int i = 0; i < 10; i++)

            {

                Console.Write(value: $"{series.Current}");
                series.Next();
            }

            Console.WriteLine();

            series.Reset();

        }
        static void Print10Number(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(value: $"{series.Current} ");

                series.Next();
            }

            Console.WriteLine();
            series.Reset();
        }


        static void Main(string[] args)
        {

            // Interfaces: Reference Type
            // Code Contract Between The Developer Who Write It And The Developer Who Use It [Implementation]

            //MyType myType = new IMyType;

            //NOTE: Can't Create Object From Any Interfaces

            //MyType myType = new MyType();
            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.MyFun();
            //myType.Print();
            //;

            ////IMyType myType1 = new IMyType();

            ////myType1.MyFun();
            //IMyType myType;

            //// Ref --> Can Refer To Object From Any Class Which Implemented The Interace 'IMyType'

            //myType = new MyType();

            //myType.Salary = 12000;

            //Console.WriteLine(myType.Salary);

            //myType.MyFun();
            //myType.Print();

            SeriesByTwo seriesByTwo = new SeriesByTwo();
            SeriesByThree seriesByThree = new SeriesByThree();
            SeriesByFour seriesByFour = new SeriesByFour();
            Print10Number(seriesByFour);

            int[] Numbers = { 7, 6, 5, 4, 3, 2, 1, 8, 9 };
            Array.Sort(Numbers);

            foreach (int item in Numbers)
            {
                Console.Write(value: $"{item}");
            }

            Employee[] employees = new Employee[3]
{

             new Employee() {Id = 1,Name = "Ahmed", Age = 30, Salary = 12000 },
            new Employee() { Id = 2, Name = "Amr", Age = 28, Salary = 13000 },
            new Employee() { Id = 3, Name = "Omar", Age = 27, Salary = 11000 }


    };


            Array.Sort(employees);

            foreach (Employee item in employees)
            {
                Console.WriteLine(item);

            }
            //Car car = new Car();

            //car. Speed = 120;
            //car. Forward();

            //Airplane airplane = new Airplane();

            //IMoveable moveable = airplane;
            //moveable.Forward();


            //IFyable flyable = airplane;
            //flyable.Forward();


            // Shallow Copy Vs Deep Copy

            //            int[] Arr01 = { 1, 2, 3 };
            //            int[] Arr02 = {4, 5, 6};

            //        Console.WriteLine(value: $"Arr01: {Arr01.GetHashCode()}|");
            //        Console.WriteLine(value: $"Arr02: {Arr02.GetHashCode()}|");

            //Arr02 = Arr01; // Shallow Copy
            //        // Copy Identity
            //        // {1, 2, 3} -> Has Two Reference Arr01, Arr02
            //        // {4, 5, 6}-> UnReachable Object

            //        Console.WriteLine();
            //       Console.WriteLine(value: $"Arr01: {Arr01.GetHashCode()}");
            //       Console.WriteLine(value: $"Arr02: {Arr02.GetHashCode()}");

            //            // Identity (Address) + Object State [Data]


            //            Arr02[0] = 100;

            //            Console.WriteLine(Arr01[0]);



           // int[] Arr01 = { 1, 2, 3 };

           // int[] Arr02 = { 4, 5, 6 };

           // Console.WriteLine(value: $"Arr01: {Arr01.GetHashCode()}");
           // Console.WriteLine(value: $"Arr02: {Arr02.GetHashCode()}");

           // Arr02 = (int[])Arr01.Clone(); // Deep Copy
           // // Clone Method Will Copy The Object State Of The Caller
           // // Assign The New Object To Arr02, Will Generete NEW Identity

           // Console.WriteLine();

           // Console.WriteLine(value: $"Arr01: {Arr01.GetHashCode()}");
           // Console.WriteLine(value: $"Arr02: {Arr02.GetHashCode()}");

           // // Identity (Address) + Object State [Data]

           // Arr02[0] = 100;

           // Console.WriteLine(Arr01[0]);
           // // Shallow Copy Vs Deep Copy

           // //int[] Arr01 = {1, 2, 3};
           // //int[] Arr02 = {4, 5, 6};

           // //string[] Arr01 = { "Ahmed", "Ali", "Omar" };
           // //string[] Arr02 = { "Ziad", "Adel", "Amr" };

           // StringBuilder

           // [] Arr01 = new StringBuilder[]
           // {
           // new StringBuilder(value: "Ahmed"),
           //new StringBuilder(value: "Ali"),
           //new StringBuilder(value: "Omar")
           // };


           // Console.WriteLine(value: $"Arr01: {Arr01.GetHashCode()}");
           // Console.WriteLine(value: $"Arr02: {Arr02.GetHashCode()}");

           // Arr02 = (StringBuilder[])Arr01.Clone();// Shallow Copy

           // // Copy Identity
           // // {1, 2, 3} -> Has Two Reference Arr01, Arr02
           // // {4, 5, 6}--> UnReachable Object
           // Console.WriteLine();

           // Console.WriteLine(value: $"Arr01: {Arr01.GetHashCode()}");
           // Console.WriteLine(value: $"Arr02: {Arr02.GetHashCode()}");

           // //// Identity (Address) + Object State [Data]

           // Arr02[0] Append("Ahmed Amin");

           // Console.WriteLine(Arr01[0]);

            //int[] Arr01 = {1, 2, 3};
            //int[] Arr02 = { 4, 5, 6};

            //Console.WriteLine($"Arr01: {Arr01.GetHashCode())");
            //Console.WriteLine($"Arr02: (Arr02.GetHashCode())");

            //Arr02 = (int[]) Arr01.Clone(); // Deep Copy
            //// Clone Method Will Copy The Object State Of The Calle
            ///


            Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 29, Salary = 12000 };
            Employee E02 = new Employee() { Id = 2, Name = "Amr", Age = 32, Salary = 11000 };

            //Ε02 = Ε01; // Shallow Copy
            //E02 = (Employee) E01.Clone(); // Deep Copy
            //E02 = new Employee (E01); // Deep Copy Copy Constructor

//            E01.Salary = 5;

//            Console.WriteLine(E01.GetHashCode());
//            Console.WriteLine(E02.GetHashCode());
//            Console.WriteLine(E01);
//            Console.WriteLine(E02);


//            Employee[] employees = new Employee[3]
//{
//new Employee() {Id = 1, Name = "Ahmed", Age =30, Salary = 12000},
//new Employee() {Id = 2, Name = "Omar", Age =27, Salary = 11000},
//new Employee() {Id = 3, Name = "Amr", Age= 28, Salary = 13000 }
//};

//            Array.Sort(employees);

//            int X = employees[0].CompareTo(employees[1]);

            //+ve: Caller Greater Than Parameter
            //-ve: Caller Less Than Parameter
            //0: Caller Equal Parameters

            //Console.WriteLine(X);
//            foreach (Employee item in employees)
//            {
//                Console.WriteLine(item);
//            }

//            Employee[] employees = new Employee[3]
//{
//new Employee() {Id = 1, Name = "Ahmed", Age =30, Salary = 12000},
//new Employee() {Id = 2, Name = "Omar", Age =27, Salary = 11000},
//new Employee() {Id = 3, Name = "Amr", Age= 28, Salary = 13000 }
//};

//            //Array.Sort(employees, new EmployeeComparer Salary());
//            Array.Sort(employees, new EmployeeComparerNameLength());

//            foreach (Employee item in employees)
//            {
//                Console.WriteLine(item);
            //}





        }


    }
}

using System;
using System.Collections.Generic;

namespace Variables_Exercise_01
{
    class Program
    {
        public struct PointA // A Value Type Container with a parameterized constructor
        {
            private double X;
            private double Y;

            public PointA(double x, double y) 
            {
                X = x;
                Y = y;
            }
        }
        public struct PointB // A Value Type Container with default constructor
        {
            public double X { get; set; }
            public double Y { get; set; }
        } 

        public enum MyEnum { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; // A Value Type Collection

        static void Main(string[] args)
        {
            var myList = new List<object>();

            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            #region List of C# Value Types https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
            //  DATATYPES         |       Size         |                     VALUES                          |
            sbyte _sbyte;               // 8 bit	                      -128 to 127
            byte _byte;                 // 8 bit	                         0 to 255
            short _short;               // 16 bit	                   -32,768 to 32,767
            ushort _ushort;             // 16 bit	                         0 to 65,535
            int _int;                   // 32 bit	            -2,147,483,648 to 2,147,483,647
            uint _uint;                 // 32 bit	                         0 to 4,294,967,295
            long _long;                 // 64 bit	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong _ulong;               // 64 bit	                         0 to 18,446,744,073,709,551,615

            // Floating point types https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            float _float;
            double _double;
            decimal _decimal;

            char _char;                 // 16 bit	                         0 to 65535
            bool _bool;                 // ~1 bit	                      True or false
            #endregion

            // TODO: Declare 5 constansts

            const int days = 10;
            const int week = 4;
            const int month = 12;
            const int year = 2021;
            const string time = "8 AM";


            // TODO: Declare 2 variables of each type from the list above (1 pair for each) 
            // Make sure to use C# naming convention best practices (camelCase, PascalCase, etc...)


            sbyte sbyteMinValue = -128;
            sbyte  sbyteMaxValue = 127;

            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;

            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;

            ushort ushortMinValue = ushort.MinValue;
            ushort ushortMaxValue = ushort.MaxValue;

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;

            uint uintMinValue = uint.MinValue;
            uint uintMaxValue = uint.MaxValue;

            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;

            ulong ulongMinValue = ulong.MinValue;
            ulong ulongMaxValue = ulong.MaxValue;

            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;

            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;

            char firstAlphabet = 'A';
            char lastAlphabet = 'Z';

            bool isValid = true;
            bool hasChanged = false;


            // TODO: Initialize 1 of the variables with that datatypes minimum value
            // TODO: Initialize the other variable with that datatypes maximum value
            // TODO: Write out each of the variables to the Console 


            Console.WriteLine($"The minimum value for sbyte datatype is {sbyteMinValue} " +
                $"and the maximum value for sbyte datatype is {sbyteMaxValue}");

            Console.WriteLine($" byte datatype Minvalue: {byteMinValue}  MaxValue: {byteMaxValue} ");
            Console.WriteLine($" short datatype Minvalue: {shortMinValue}  MaxValue: {shortMaxValue} ");
            Console.WriteLine($" ushort datatype Minvalue: {ushortMinValue}  MaxValue: {ushortMaxValue} ");
            Console.WriteLine($" int datatype Minvalue: {intMinValue}  MaxValue: {intMaxValue} ");
            Console.WriteLine($" uint datatype Minvalue: {uintMinValue}  MaxValue: {uintMaxValue} ");
            Console.WriteLine($" long datatype Minvalue: {longMinValue}  MaxValue: {longMaxValue} ");
            Console.WriteLine($" ulong datatype Minvalue: {ulongMinValue}  MaxValue: {ulongMaxValue} ");
            Console.WriteLine($" float datatype Minvalue: {floatMinValue}  MaxValue: {floatMaxValue} ");
            Console.WriteLine($" double datatype Minvalue: {doubleMinValue}  MaxValue: {doubleMaxValue} ");
            Console.WriteLine($" decimal datatype Minvalue: {decimalMinValue}  MaxValue: {decimalMaxValue} ");

            Console.WriteLine(isValid?firstAlphabet:lastAlphabet);

            


            // **BONUS**
            // TODO: Create your own enum and initialize it with constants of your choosing
            // TODO: Declare it and then iterate through it writing out to the console            
            // TODO: Instantiate a struct and initialize all of it's members

            // enum month { January,February, March, April, May,June,July,August,September,October,November,December};

        }

    }
}

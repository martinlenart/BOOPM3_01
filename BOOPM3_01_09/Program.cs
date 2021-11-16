using System;

namespace BOOPM3_01_09
{
    class Program
    {
        public static class FooClass
        {
            //For overloading the signature is name and parameter types (in order).
            //I call it OL-signature
            //Methods can be overloaded if no OL-signature conflict exist
            public static string MetodA(int x, double y) => "int and double";
            public static double MetodA(double x, int y) => x;          // OK - no OL-signature conflict 
            public static double MetodA(double x) => x;                 // OK - no OL-signature conflict 
            public static string MetodA(double x) => "double";          // Not OK - signature conflict, compiler error 
            public static string MetodA(double x, bool b) => "double";  // OK - no OL-signature conflict  
            public static bool MetodA(double x, bool b) => b;           // Not OK - signature conflict, compiler error  
        }
        static void Main(string[] args)
        {
        }
    }

    //Excercises:
    //1.    Implement two methods overloading with conflicting signature
    //2.    Implement two methods with non-conflicting signatures, but each has a local method,
    //      with exactly the same signature. Will this work?
}

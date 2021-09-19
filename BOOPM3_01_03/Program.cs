using System;

namespace BOOPM3_01_03
{
    class Program
    {
        public struct valueTypePoint { public int X, Y; }
        public class referenceTypePoint { public int X, Y; }

        public readonly struct immutableValueTypePoint 
        { 
            readonly public int X, Y; 
            public immutableValueTypePoint(int X, int Y)
            { 
                this.X = X;
                this.Y = Y;
            }
        }
        public class immutableReferenceTypePoint 
        {
            readonly public int X, Y;
            public immutableReferenceTypePoint(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }
        }

        static void Main(string[] args)
        {
            var vp1 = new valueTypePoint { X = 3, Y = 5 };
            var rp1 = new referenceTypePoint { X = 3, Y = 5 };

            //demonstrate mutable
            vp1.X = rp1.X = 10;
            Console.WriteLine($"{nameof(vp1)}={(vp1.X, vp1.Y)}"); // I convert to tuple in printout
            Console.WriteLine($"{nameof(rp1)}={(rp1.X, vp1.Y)}"); // I use nameof() for easy renaming

            var imvp1 = new immutableValueTypePoint (X:3, Y:5); // named parameters
            var imrp1 = new immutableReferenceTypePoint(3, 5) ; // positional parameters

            //demonstrate mutable
            //imvp1.X = imrp1.X = 10;     // Compiler error as the types are immutable
            Console.WriteLine($"{nameof(imvp1)}={(imvp1.X, imvp1.Y)}");
            Console.WriteLine($"{nameof(imrp1)}={(imrp1.X, imrp1.Y)}");
        }
    }
    //Exercises:
    //1.    Modify write a constructor to immutableReferenceTypePoint so the code
    //      imrp2 = new immutableReferenceTypePoint();
    //      creates a point that is initiated to X=0 and Y=0
}

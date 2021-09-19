﻿using System;

namespace BOOPM3_01_10
{
    class Program
    {
        public struct WineStruct
        {
            public decimal Price { get; set; }
            public int Year { get; set; }
            public WineStruct(decimal price) 
            { 
                Price = price; 
                Year = default; 
            }
            public WineStruct(decimal price, int year) : this(price) => Year = year;
        }
        public class WineClass
        {
            public decimal Price { get; set; } = default;
            public int Year { get; set; } = default;

            public WineClass(decimal price) => Price = price;

            //Note I deviate from C# naming convention show the "this" keyword
            public WineClass(decimal price, int Year) : this(price) => this.Year = Year;
        }
        static void Main(string[] args)
        {
            var ws1 = new WineStruct(78);
            var ws2 = new WineStruct(78, 2001);
  
            var wc1 = new WineClass(78);
            var wc2 = new WineClass(78, 2001);

            Console.WriteLine(ws1.Equals(ws2));                 // false
            Console.WriteLine(ws1.Equals(ws2));                 // false
            ws1.Year = 2001;
            Console.WriteLine(ws1.Equals(ws2));                 // true

            Console.WriteLine(wc1.Equals(wc2));                 // false
            Console.WriteLine(wc1.Equals(wc2));                 // false
            wc1.Year = 2001;
            Console.WriteLine(wc1.Equals(wc2));                 // false

            //Using Object initialization
            var ws3 = new WineStruct { Price = 250, Year = 1964 };
        }
    }

    //Excercises:
    //1.    Explain the difference in the last compare ws1.Equals(ws2) vs last compare wc1.Equals(wc2)
    //2.    Try to use Object initialization creating an object instance of WineClass
    //      You will need to create a parameterless constructor for WineClass. Can you create one for WineStruct?
    //3.    Add a property string Name to both WineClass and WineStruct. Modify the parameterless constructor in
    //      WineClass to set Name, Price and Year to your favorite wine.
    //      How would you create an instance of your favorite wine in WineStruct?
}
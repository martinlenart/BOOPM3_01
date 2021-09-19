using System;

namespace BOOPM3_01_02
{
    class Program
    {
		public class Apple
		{
			public string Name;             // Instance field
			public static int NrInstances;  // Static field

			public Apple(string n)
			{
				Name = n;                      // Assign the instance field
				NrInstances = NrInstances + 1; // Increment the static field
			}
		}
		static void Main(string[] args)
		{
			Apple a1 = new Apple("Pink Lady");
			Apple a2 = new Apple("Discovery");

			Console.WriteLine(a1.Name);      // Pink Lady
			Console.WriteLine(a2.Name);      // Discovery

			Console.WriteLine(Apple.NrInstances);   // 2        
		}
	}
	//Exercises:
	//1.	Add 2 public static variables, float Heaviest, float Lightes.  	
	//		Modify the code so it also keept track of the heaviest and lightest Apple object instanciated. 
	//		Write the weight of the heaviest and lightest Apple object instantiated.

}

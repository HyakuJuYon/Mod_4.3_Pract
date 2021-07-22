using System;

namespace Mod_4._3_Pract
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Write your name");

			var name = Console.ReadLine();

			Console.WriteLine("Your name spelled as: ");

			foreach (var ch in name)
			{
				Console.Write(ch + " ");
			}
			
			Console.WriteLine("The first letter of your name is {0}:", name[0]);

			Console.ReadKey();
		}
    }
}

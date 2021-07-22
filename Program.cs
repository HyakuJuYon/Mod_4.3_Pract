using System;

namespace Mod_4._3_Pract
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Write your name");

			var name = Console.ReadLine();

			for (int i = name.Length - 1; i >= 0; i--)

			{

				Console.Write(name[i] + "");

			}
			Console.ReadKey();
		}
	}
}
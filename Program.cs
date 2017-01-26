using System;

namespace package_delivery_service
{
	class MainClass
	{
		/*
		 * Write a program for a package delivery service. The program
		 * contains an array that holds the ten zip codes to which the
		 * company delivers packages. Prompt the user to enter a zip
		 * code and display a message indicating whether the zip code 
		 * is one to which the company delivers.
		 */

		public static void Main(string[] args)
		{
			string[] zipArray = { "95632", "84065", "46001", "58432", "90210", "90202", "89345", "34509", "10023", "23009" };

			Console.WriteLine("Enter zip code");
			string code = Console.ReadLine();

			bool found = false;

			for (int i = 0; i < zipArray.Length; i++)
			{
				if (code == zipArray[i])
				{
					found = true;
					break;
				}
			}

			if (found == true)
			{
				Console.WriteLine("We do ship to that location");
			}
			else
			{
				Console.WriteLine("We do not ship there");
			}
		}
	}
}

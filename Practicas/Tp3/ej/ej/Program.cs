/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 15/4/2016
 * Time: 19:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace ej
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num = Console.Read();
			Console.Write(num);
			while(num!=0)
			{
				Console.WriteLine(num);
				num = Console.Read();
			}
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
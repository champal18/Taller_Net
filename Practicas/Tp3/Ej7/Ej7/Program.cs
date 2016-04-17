/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 16/4/2016
 * Time: 16:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x = 0;
			try
			{
				Console.WriteLine(1.0/x);
				Console.WriteLine(1/x);
				Console.WriteLine("ok");
			} catch
			{
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 03/05/2016
 * Time: 02:44 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sum=0; 
			int i=1; 
			while (i<=10)
			{ 
				sum += i++; 
			}

			Console.Write("Suma:"+sum);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
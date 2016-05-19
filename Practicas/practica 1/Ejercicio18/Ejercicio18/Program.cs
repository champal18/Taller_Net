/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 19/05/2016
 * Time: 03:10 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio18
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese año");
			
			string st1=Console.ReadLine();
			int a=int.Parse(st1);
			if(((a%4==0) && (a%100!=0))||((a%100==0) && (a%400==0)))
			{
				Console.WriteLine("Es bisiesto");
			}
			else
			{
				Console.WriteLine("No es bisiesto");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
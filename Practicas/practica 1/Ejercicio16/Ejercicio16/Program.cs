/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 19/05/2016
 * Time: 03:02 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio16
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese numero");
			string st;
			st=Console.ReadLine();
			int n=int.Parse(st);
			int n2=n*365;
			string st2=n2.ToString();
			int i=st2.Length-1;
			while(i>=0)
			{			
				Console.WriteLine("\n"+st2[i]);
				i--;
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}